namespace ObserverPattern.PushObserver
{
    public interface IPushObservable<out T>
    {
        void Subscribe(IPushObserver<T> subscriber);
        void Unsubscribe(IPushObserver<T> subscriber);
    }
}