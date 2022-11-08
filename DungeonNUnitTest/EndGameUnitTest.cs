using Dungeon.Monsters;
using Dungeon;

namespace DungeonNUnitTest
{
    public class Tests
    {
        private (int, int) _bossPosition;
        private Boss _boss;
        private Alice _player;

        [SetUp]
        public void Setup()
        {
            _bossPosition = (44, 44);
            _boss = new Boss(_bossPosition);
            _player = new Alice();
        }

        [Test]
        public void CheckForEndGame()
        {


            //if (_player.Health <= 1)
            //{
            //    Display.EndGameLost();
            //    return false;
            //}
            //else if (_boss.Health <= 1)
            //{
            //    Display.EndGameWon();
            //    return false;
            //}
            //return true;
        }
    }
}