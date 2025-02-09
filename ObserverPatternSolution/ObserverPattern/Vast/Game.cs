using ObserverPattern.PushObserver;

namespace ObserverPattern.Vast
{
    public sealed class Game: IPushObserver<Dragon>, IPushObserver<Thief>, IPushObserver<Knight>
    {
        public string Winner { get; private set; } = "None";

        public void Update(Dragon state)
        {
            if(state.HasEscaped)
            {
                Winner = "Dragon";
            }

            if(state.IsDead)
            {
                Winner = "Knight";
            }
        }

        public void Update(Thief state)
        {
            if (state.TreasuresSecured >= 6)
            {
                Winner = "Thief";
            }
        }

        public void Update(Knight state)
        {
            if (state.IsDead)
            {
                Winner = "Goblins";
            }
        }
    }
}