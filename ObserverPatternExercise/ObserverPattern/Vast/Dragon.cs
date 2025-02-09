namespace ObserverPattern.Vast
{
    public class Dragon
    {
        private int _health = 5;

        public bool IsDead => _health < 1;
        public bool HasEscaped { get; private set; }

        public void TakeDamage()
        {
            _health--;
        }

        public void Escape()
        {
            HasEscaped = true;
        }
    }
}