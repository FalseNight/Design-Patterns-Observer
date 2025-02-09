using ObserverPattern.PushObserver;
using System.Collections.Generic;

namespace ObserverPattern.Vast
{
    public sealed class Knight : IPushObservable<Knight>
    {
        private List<IPushObserver<Knight>> _subscribers = new List<IPushObserver<Knight>>();
        private int _health = 7;

        public bool IsDead => _health < 1;

        public void TakeDamage()
        {
            _health--;

            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        public void Subscribe(IPushObserver<Knight> subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(IPushObserver<Knight> subscriber)
        {
            _subscribers.Remove(subscriber);
        }
    }
}