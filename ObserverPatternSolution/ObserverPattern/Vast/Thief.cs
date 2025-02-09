using ObserverPattern.PushObserver;
using System.Collections.Generic;

namespace ObserverPattern.Vast
{
    public sealed class Thief : IPushObservable<Thief>
    {
        private List<IPushObserver<Thief>> _subscribers = new List<IPushObserver<Thief>>();
        public int TreasuresSecured = 0;

        public void SecureTreasure()
        {
            TreasuresSecured++;

            foreach(var subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        public void Subscribe(IPushObserver<Thief> subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(IPushObserver<Thief> subscriber)
        {
            _subscribers.Remove(subscriber);
        }
    }
}