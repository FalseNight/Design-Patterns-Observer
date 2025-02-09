namespace ObserverPattern.PushObserver
{
    public interface IPushObserver<in T>
    {
        void Update(T state);
    }
}