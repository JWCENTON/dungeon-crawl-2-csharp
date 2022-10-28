using Dungeon.Monsters;

namespace Dungeon.Fight
{
    public class Fight
    {
        public void FightWithMonster(Character player, Monster monster)
        {
            var isFightContinues = true;

            while (isFightContinues)
            {
                player.Health -= monster.AtackValue;
                monster.Health -= player.AtackValue;

                if (player.Health <= 0 || monster.Health <= 0)
                {
                    isFightContinues = false;
                    correctStatusAliveChar(player);
                    correctStatusAliveMonster(monster, player);
                }
            }
        }

        private void correctStatusAliveChar(Character player)
        {
            if (player.Health <= 0)
            {
                player.IsAlive = false;
            }
        }
        private void correctStatusAliveMonster(Monster monster, Character player)
        {
            if (monster.Health <= 0)
            {
                monster.IsAlive = false;
                player.AtackValue += 10;
            }
        }
    }
}
