namespace ObserverPattern.Vast
{
    public sealed class Knight
    {
        private int _health = 7;

        public bool IsDead => _health < 1;

        public void TakeDamage()
        {
            _health--;
        }
    }
}