Il **Builder Pattern** è un design pattern creazionale che separa la costruzione di un oggetto complesso dalla sua rappresentazione, consentendo di creare diverse rappresentazioni dello stesso tipo di oggetto. Questo pattern è particolarmente utile quando un oggetto ha molte proprietà opzionali o quando la sua costruzione richiede diversi passi.

Un esempio reale molto usato del **Builder Pattern** si trova nella costruzione di **oggetti complessi con molte opzioni**, come un **HTTP request** o la creazione di un **oggetto immutabile**. 

Vediamo un esempio concreto e ampiamente utilizzato, come la costruzione di una richiesta HTTP (`HttpRequestMessage`), o un'analogia costruita con un **costruttore di pizza**.

### 1. **Scenario: Creazione di un oggetto HTTP request**
Immagina di voler costruire un oggetto di richiesta HTTP con molte proprietà opzionali, come metodo, URL, intestazioni, corpo, ecc. Usando il **Builder Pattern**, possiamo gestire queste opzioni in modo leggibile e flessibile.

### 2. **Esempio Reale con il Builder Pattern**:

Supponiamo di dover costruire una richiesta HTTP, dove solo alcune proprietà sono obbligatorie (come il metodo e l'URL), ma altre (intestazioni, contenuto, ecc.) sono opzionali.

#### Classe HTTP Request (oggetto da costruire):

```csharp
public class HttpRequest
{
    public string Method { get; private set; }
    public string Url { get; private set; }
    public string Body { get; private set; }
    public Dictionary<string, string> Headers { get; private set; }

    public HttpRequest(string method, string url, string body, Dictionary<string, string> headers)
    {
        Method = method;
        Url = url;
        Body = body;
        Headers = headers;
    }

    public override string ToString()
    {
        return $"Method: {Method}, Url: {Url}, Body: {Body}, Headers: {string.Join(", ", Headers)}";
    }
}
```

#### Builder per la classe HttpRequest:

Ora, creiamo un **Builder** per costruire l'oggetto `HttpRequest` passo dopo passo.

```csharp
public class HttpRequestBuilder
{
    private string _method;
    private string _url;
    private string _body;
    private Dictionary<string, string> _headers = new Dictionary<string, string>();

    // Metodo per settare il metodo HTTP
    public HttpRequestBuilder SetMethod(string method)
    {
        _method = method;
        return this; // Restituisce lo stesso builder per il chaining
    }

    // Metodo per settare l'URL
    public HttpRequestBuilder SetUrl(string url)
    {
        _url = url;
        return this;
    }

    // Metodo per settare il corpo della richiesta
    public HttpRequestBuilder SetBody(string body)
    {
        _body = body;
        return this;
    }

    // Metodo per aggiungere un'intestazione
    public HttpRequestBuilder AddHeader(string key, string value)
    {
        _headers[key] = value;
        return this;
    }

    // Metodo finale per costruire l'oggetto HttpRequest
    public HttpRequest Build()
    {
        // Puoi anche aggiungere logiche di validazione prima di costruire
        if (string.IsNullOrEmpty(_method) || string.IsNullOrEmpty(_url))
        {
            throw new InvalidOperationException("Method and URL must be provided.");
        }

        return new HttpRequest(_method, _url, _body, _headers);
    }
}
```

#### Uso del Builder:

Ora possiamo usare il **Builder** per costruire una richiesta HTTP in modo leggibile e flessibile:

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Costruzione di una richiesta HTTP utilizzando il builder
        HttpRequest request = new HttpRequestBuilder()
            .SetMethod("POST")
            .SetUrl("https://api.example.com/data")
            .SetBody("{\"name\":\"John\"}")
            .AddHeader("Authorization", "Bearer token123")
            .AddHeader("Content-Type", "application/json")
            .Build();

        Console.WriteLine(request);
    }
}
```

#### Output:
```
Method: POST, Url: https://api.example.com/data, Body: {"name":"John"}, Headers: [Authorization: Bearer token123, Content-Type: application/json]
```

### 3. **Vantaggi dell'uso del Builder Pattern**:

- **Facilità di lettura e mantenibilità**: Ogni passo della costruzione è chiaro, grazie all'uso del **fluent interface** (chaining dei metodi).
- **Flessibilità nella costruzione**: Non sei obbligato a passare tutti i parametri al costruttore contemporaneamente, e puoi facilmente ignorare proprietà non necessarie.
- **Oggetti immutabili**: L'oggetto finale creato (`HttpRequest`) è immutabile (tutte le proprietà sono `private set`), riducendo i rischi di modifiche accidentali.

### 4. **Altri esempi d'uso reale del Builder Pattern**:

- **Configurazione di un database**: La configurazione di connessioni a database può diventare complessa (ad esempio, configurazioni di pooling, timeout, ecc.). Usando il Builder, puoi impostare solo i valori rilevanti e costruire l'oggetto di connessione in modo flessibile.
- **Creazione di oggetti JSON complessi**: Il Builder può essere utilizzato per costruire JSON complessi da inviare via API, dove non tutte le proprietà sono sempre necessarie.
- **Costruzione di query SQL**: In sistemi di accesso ai dati, il Builder Pattern è molto utile per costruire query SQL dinamiche in base ai filtri e alle condizioni specificate dall'utente.

### Conclusione:
Il **Builder Pattern** è molto utile quando si devono creare oggetti complessi, specialmente quelli con molte proprietà opzionali. Il pattern aiuta a mantenere il codice leggibile e facile da mantenere, evitando costruttori con troppi parametri o la creazione di varianti di oggetti duplicando codice.
