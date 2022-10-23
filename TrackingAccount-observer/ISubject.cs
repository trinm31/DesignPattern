namespace TrackingAccount_observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void NotifyAllObserver();
    }
}