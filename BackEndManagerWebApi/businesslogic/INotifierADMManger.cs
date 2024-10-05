using BackEndManagerBusinessLogic.signalr;
using System;

namespace BackEndManagerWebApi.businesslogic;
public class INotifierADMManger : ISubjectSignalR {
    private List<IObserverSignalR> _observers = new List<IObserverSignalR>();

    public void Attach(IObserverSignalR observer) {
        _observers.Add(observer);
    }

    public void Detach(IObserverSignalR observer) {
        _observers.Remove(observer);
    }

    public void Notify(string message) {
        foreach (var observer in _observers) {
            observer.Update(message);
        }
    }
    public void UpdateStock() {
        // Logica di aggiornamento dello stock...
        Notify("L'inventario è stato aggiornato.");
    }
}
