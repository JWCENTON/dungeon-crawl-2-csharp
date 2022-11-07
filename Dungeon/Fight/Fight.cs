using Dungeon.Enum;
using Dungeon.Maps;
using Dungeon.Monsters;
using System.Numerics;
using System.Threading;

namespace Dungeon.Fight
{
    public class Fight
    {
        private void DisplayFight(FileReader.FileReader shield, Character player, Monster boss)
        {
            foreach (var line in shield.Read())
            {
                Console.Write($"{line}");
            }
            Console.WriteLine($"\tBoos health: {boss.Health} Attack: {boss.AtackValue} | {player.Name} health: {player.Health} | {player.Name} Attack: {player.AtackValue}");
            Console.WriteLine("\tA for ATTACK or Q to quit fight"); // TODO Boss fight in turns!
        }

        public void FightBoss(Character player, Map map, Monster boss)
        {
            var shield = new FileReader.FileReader(Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, "shield.txt")));
            DisplayFight(shield, player, boss);
            bool endFight = false;
            while (!endFight)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.A:
                            Console.Clear();
                            player.Health -= boss.AtackValue;
                            boss.Health -= player.AtackValue;
                            boss.AtackValue += 1;
                            if (player.Health <= 0 || boss.Health <= 0)
                            {
                                endFight = true;
                                correctStatusAlive(player);
                                correctStatusAlive(boss);
                            }
                            DisplayFight(shield, player, boss);
                            break;
                        case ConsoleKey.Q:
                            endFight = true;
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
                monster.Health -= player.AtackValue;

                if (player.Health <= 0 || monster.Health <= 0)
                {
                    isFightContinues = false;
                    correctStatusAlive(player);
                    correctStatusAlive(monster);
                }
            }
            player.AtackValue += 10;
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
