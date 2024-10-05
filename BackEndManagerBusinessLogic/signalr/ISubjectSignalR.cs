namespace BackEndManagerBusinessLogic.signalr;
public interface ISubjectSignalR {
    void Attach(IObserverSignalR observer);
    void Detach(IObserverSignalR observer);
    void Notify(string message);
}