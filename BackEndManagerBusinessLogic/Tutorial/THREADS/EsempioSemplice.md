Se vuoi implementare un meccanismo per limitare la coda di lavoro in **`ThreadPool.QueueUserWorkItem`** a un massimo di 100 elementi in coda, puoi farlo manualmente utilizzando strutture di sincronizzazione come **`SemaphoreSlim`** o **`BlockingCollection<T>`**.

### Soluzione con **`SemaphoreSlim`**
Puoi utilizzare **`SemaphoreSlim`** per limitare il numero massimo di task che possono essere accodati o eseguiti contemporaneamente. In questo caso, limitiamo la coda a un massimo di 100 elementi.

#### Esempio:
```csharp
using System;
using System.Threading;

class Program
{
    // Limite massimo per gli elementi nella coda
    private static SemaphoreSlim semaphore = new SemaphoreSlim(100);

    static void Main(string[] args)
    {
        for (int i = 0; i < 150; i++)
        {
            int taskNumber = i;

            // Attendere fino a che ci sia un posto disponibile
            semaphore.Wait();

            ThreadPool.QueueUserWorkItem(_ =>
            {
                try
                {
                    Console.WriteLine($"Inizio lavoro {taskNumber}");

                    // Simula un lavoro che impiega tempo
                    Thread.Sleep(1000);

                    Console.WriteLine($"Lavoro {taskNumber} completato");
                }
                finally
                {
                    // Rilascia il semaforo per consentire nuove attività
                    semaphore.Release();
                }
            });
        }

        // Aspetta fino a che tutte le operazioni sono completate
        Console.WriteLine("Tutti i lavori sono stati accodati.");
        Console.ReadLine(); // Mantieni il programma in esecuzione
    }
}
```

### Spiegazione:
1. **`SemaphoreSlim semaphore = new SemaphoreSlim(100)`**: Definisce un semaforo con un massimo di 100 posti disponibili. Questo limita a 100 il numero massimo di lavori che possono essere contemporaneamente in esecuzione o in attesa.
2. **`semaphore.Wait()`**: Ogni volta che si cerca di aggiungere un nuovo elemento alla coda, il semaforo controlla se ci sono slot disponibili. Se il numero di elementi in esecuzione raggiunge il massimo (100), il thread attende finché non si libera uno slot.
3. **`ThreadPool.QueueUserWorkItem`**: Viene utilizzato per mettere in coda il lavoro nel pool di thread. Dopo che il lavoro è completato, **`semaphore.Release()`** rilascia un posto nel semaforo per permettere l'accodamento di nuovi lavori.
4. **`Thread.Sleep(1000)`**: Simula un lavoro che impiega 1 secondo per essere completato.
5. **`Console.ReadLine()`**: Mantiene l'applicazione in esecuzione per consentire l'osservazione dei risultati.

### Soluzione con **`BlockingCollection<T>`**
Un'altra soluzione più esplicita per limitare la coda è usare **`BlockingCollection<T>`**, che consente di limitare il numero massimo di elementi accodati e blocca l'inserimento di nuovi elementi quando il limite è raggiunto.
