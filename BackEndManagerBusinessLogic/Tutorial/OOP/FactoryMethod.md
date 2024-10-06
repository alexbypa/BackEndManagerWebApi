Il **Factory Method** è un design pattern creazionale che fornisce un'interfaccia per creare oggetti, ma permette alle sottoclassi di decidere quale classe concreta istanziare. Questo pattern è utile quando la creazione degli oggetti è complessa o dipende da condizioni specifiche.

Un esempio reale del **Factory Method** potrebbe essere una situazione in cui hai diversi tipi di notifiche (e-mail, SMS, push) e vuoi che il sistema decida dinamicamente quale tipo di notifica creare in base a determinati parametri.

### 1. **Scenario**:
Immaginiamo di avere un sistema che invia notifiche. A seconda della configurazione dell'utente, il sistema potrebbe dover inviare:
- Una notifica via **Email**
- Una notifica via **SMS**
- Una notifica via **Push Notification**

Usiamo il pattern Factory Method per creare la notifica appropriata senza dover cambiare il codice ogni volta che viene aggiunto un nuovo tipo di notifica.

### 2. **Codice Esempio**:

#### Interfaccia Notifica:
Definiamo un'interfaccia `INotification` che tutte le notifiche devono implementare.

```csharp
public interface INotification
{
    void Send(string message);
}
```

#### Implementazioni Concreti di Notifiche:
Ora creiamo implementazioni specifiche di questa interfaccia per ogni tipo di notifica.

```csharp
public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email inviata con messaggio: {message}");
    }
}

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS inviato con messaggio: {message}");
    }
}

public class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Push Notification inviata con messaggio: {message}");
    }
}
```

#### Classe Factory (metodo factory):
Ora definiamo la **classe factory** che utilizza il metodo factory per creare l'oggetto `INotification` corretto.

```csharp
public abstract class NotificationFactory
{
    // Factory Method
    public abstract INotification CreateNotification();

    public void Notify(string message)
    {
        // Usa il Factory Method per creare l'oggetto corretto
        var notification = CreateNotification();
        notification.Send(message);
    }
}
```

#### Implementazioni concrete della Factory:
Ogni tipo di notifica avrà la sua factory, che deciderà quale classe di notifica creare.

```csharp
public class EmailNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}

public class SmsNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}

public class PushNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new PushNotification();
    }
}
```

#### Uso del Factory Method:
Ora possiamo creare dinamicamente la notifica corretta e inviare il messaggio senza preoccuparci del tipo concreto di notifica.

```csharp
public class NotificationService
{
    private readonly NotificationFactory _factory;

    public NotificationService(NotificationFactory factory)
    {
        _factory = factory;
    }

    public void SendNotification(string message)
    {
        _factory.Notify(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creiamo una Email Notification
        NotificationService emailService = new NotificationService(new EmailNotificationFactory());
        emailService.SendNotification("Hello via Email!");

        // Creiamo una SMS Notification
        NotificationService smsService = new NotificationService(new SmsNotificationFactory());
        smsService.SendNotification("Hello via SMS!");

        // Creiamo una Push Notification
        NotificationService pushService = new NotificationService(new PushNotificationFactory());
        pushService.SendNotification("Hello via Push Notification!");
    }
}
```

### 3. **Spiegazione**:
- **`NotificationFactory`**: La classe astratta che definisce il metodo factory `CreateNotification`. Questo metodo viene implementato dalle sottoclassi per creare l'oggetto corretto (`EmailNotification`, `SmsNotification`, o `PushNotification`).
- **`NotificationService`**: La classe che utilizza il factory method per inviare una notifica. Non ha bisogno di sapere quale tipo specifico di notifica viene creato, poiché utilizza il factory method per astrarre la logica di creazione.
- **Factory concrete**: Ogni sottoclasse (`EmailNotificationFactory`, `SmsNotificationFactory`, `PushNotificationFactory`) decide quale classe concreta di notifica creare.

### 4. **Vantaggi del Factory Method**:
- **Apertura/Chiusura**: Il pattern segue il principio di apertura/chiusura (Open/Closed Principle), in quanto è possibile estendere il sistema (aggiungere nuovi tipi di notifica) senza modificare il codice esistente.
- **Astrazione della creazione**: La creazione di oggetti è astratta dalla logica di business, il che rende il codice più facile da mantenere e testare.
- **Flessibilità**: Consente di cambiare il tipo di oggetto da creare senza modificare il client che utilizza la factory.

### Conclusione:
Il **Factory Method** è utile quando devi delegare la creazione di oggetti a sottoclassi, permettendo così una maggiore flessibilità e manutenibilità del codice.
