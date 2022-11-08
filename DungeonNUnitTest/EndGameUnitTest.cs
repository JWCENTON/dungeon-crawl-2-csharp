using Dungeon.Monsters;
using Dungeon;
using System.Numerics;

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
        [TestCase(0)]
        [TestCase(-10)]
        public void CheckIfPLayersHeathWhenZeroOrBelowEndsGame(int health)
        {
            // arrange
            _player.Health = health;
            _boss.Health = health;

            // act

            // assert
            Assert.IsFalse(EndGame.CheckForEndGame(_player, _boss));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void CheckIfBossHeathWhenZeroOrBelowEndsGame(int health)
        {
            // arrange
            _boss.Health = health;

            // act

            // assert
            Assert.IsFalse(EndGame.CheckForEndGame(_player, _boss));
        }
    }
}