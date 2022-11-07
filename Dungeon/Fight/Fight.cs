using System.ComponentModel;
using Dungeon.Enum;
using Dungeon.Maps;
using Dungeon.Monsters;
using System.Threading;

namespace Dungeon.Fight
{
    public class Fight
    {
        public void FightBoss(Character player, Map map)
        {
            map.FullMap[44, 44] = new Square(Status.Empty);
            map.FullMap[44, 45] = new Square(Status.Empty);
            map.FullMap[44, 45] = new Square(Status.Empty);
            Console.Write("FIGHT"); // TODO Boss fight in turns!
            var a = Console.Read();
            bool endFight = false;
            while (!endFight)
            {
                if (Console.KeyAvailable)
                {
                    FightOption fightOption;
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.A:
                            fightOption = FightOption.attack;
                            Console.WriteLine("YESS ATTACK ");
                            break;
                        case ConsoleKey C:
                            break;
                    }

                }
            }
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
