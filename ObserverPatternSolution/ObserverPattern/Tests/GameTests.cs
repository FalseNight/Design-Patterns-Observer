using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern.Vast;

namespace ObserverPattern.Tests
{
    [TestClass]
    public class GameTests
    {
        private Game _game;
        private Knight _knight;
        private Dragon _dragon;
        private Thief _thief;

        [TestInitialize]
        public void Init()
        {
            _game = new Game();
            _knight = new Knight();
            _thief = new Thief();
            _dragon = new Dragon();
            _dragon.Subscribe(_game);
            _thief.Subscribe(_game);
            _knight.Subscribe(_game);
        }

        [TestMethod]
        public void Game_DragonHasEscaped_DragonHasWon()
        {
            _dragon.Escape();

            AssertWinnerIs("Dragon");
        }

        [TestMethod]
        public void Game_ThiefHasStolenSixTreasures_ThiefHasWon()
        {
            _thief.SecureTreasure();
            _thief.SecureTreasure();
            _thief.SecureTreasure();
            _thief.SecureTreasure();
            _thief.SecureTreasure();
            _thief.SecureTreasure();

            AssertWinnerIs("Thief");
        }

        [TestMethod]
        public void Game_DragonHasBeenSlain_KnightHasWon()
        {
            _dragon.TakeDamage();
            _dragon.TakeDamage();
            _dragon.TakeDamage();
            _dragon.TakeDamage();
            _dragon.TakeDamage();

            AssertWinnerIs("Knight");
        }

        [TestMethod]
        public void Game_KnightHasBeenSlain_GoblinsHaveWon()
        {
            _knight.TakeDamage();
            _knight.TakeDamage();
            _knight.TakeDamage();
            _knight.TakeDamage();
            _knight.TakeDamage();
            _knight.TakeDamage();
            _knight.TakeDamage();

            AssertWinnerIs("Goblins");
        }

        private void AssertWinnerIs(string player)
        {
            Assert.AreNotEqual("None", _game.Winner, "Game has not finished.");
            Assert.AreEqual(player, _game.Winner);
        }
    }
}