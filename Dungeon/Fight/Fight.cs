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
                    correctStatusAlive(player);
                    correctStatusAlive(monster);
                }
            }
        }

        private void correctStatusAlive(IHealth arg)
        {
            if (arg.Health <= 0)
            {
                arg.IsAlive = false;
            }
        }
    }
}
