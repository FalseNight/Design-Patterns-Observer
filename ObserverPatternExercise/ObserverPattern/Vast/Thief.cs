namespace ObserverPattern.Vast
{
    public sealed class Thief
    {
        public int TreasuresSecured = 0;

        public void SecureTreasure()
        {
            TreasuresSecured++;
        }
    }
}