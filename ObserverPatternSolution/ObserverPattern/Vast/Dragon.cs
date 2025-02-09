using ObserverPattern.PushObserver;
using System.Collections.Generic;

namespace ObserverPattern.Vast
{
    public class Dragon: IPushObservable<Dragon>
    {
        private List<IPushObserver<Dragon>> _subscribers = new List<IPushObserver<Dragon>>();
        private int _health = 5;

        public bool IsDead => _health < 1;
        public bool HasEscaped { get; private set; }

        public void TakeDamage()
        {
            _health--;

            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        public void Escape()
        {
            HasEscaped = true;

            foreach(var subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }

        public void Subscribe(IPushObserver<Dragon> subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(IPushObserver<Dragon> subscriber)
        {
            _subscribers.Remove(subscriber);
        }
    }
}