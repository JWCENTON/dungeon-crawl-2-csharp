using Dungeon.Enum;
using Dungeon.Monsters;
using System.Threading;

namespace Dungeon.Fight
{
    public class Fight
    {
        public void FightBoss(Character player, Monster monster)
        {
            Console.WriteLine("FIGHT") // TODO Boss fight in turns!
        }
        public void FightWithMonster(Character player, Monster monster)
        {
            var isFightContinues = true;

            while (isFightContinues)
            {
                player.Health -= monster.AtackValue;
                player.AtackValue += 10;
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
