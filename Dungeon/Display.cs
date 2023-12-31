﻿using System.Net.NetworkInformation;
using System.Text;
using Dungeon.Maps;
using Dungeon.Monsters;

namespace Dungeon
{
    public class Display
    {
        public static void DisplayRow(string row)
        {
            Console.WriteLine(row);
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        private static void ShowLegend(Character player)
        {
            Console.WriteLine("\tPress E to show equipment | F5 to save the game | F9 to load previously saved state");
        }
        private static void PLayerHealthAndPosition(Character player, Monster boss)
        {
            string space = "     ";
            string lifeBar = new string('+', (player.Health / 10));

            Console.Write($"{space}{player.Name}: Health {lifeBar}({lifeBar.Length} out of 10) (Y: {player.Position.x}, X: {player.Position.y}) ");
            Console.WriteLine($" Attack strength: {player.AtackValue} BOSS health: {boss.Health}");
        }

        public static void PlayerEquipment(Character player)
        {
            var keySign = "K";
            var appleSign = "A";
            Console.Write($"\tEquipment : ");
            foreach (var item in player.Equipment)
            {
                if (item == keySign)
                {
                    Console.Write($"Key | ");
                }
                else if (item == appleSign)
                {
                    Console.Write($"Apple | ");
                }
            }
        }
        public static void Map(Map map, Character player)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string space = "     ";
            MapManager.PutObjectOnMap(map, player.Position, player.Type);
            MapName(map);
            Console.WriteLine();
            for (var i = player.Position.x - 10 ; i <= (player.Position.x + 10); i++)
            {

                Console.WriteLine("\n");
                for (var j = player.Position.y - 20; j <= (player.Position.y + 20); j++)
                {
                    if (j == player.Position.y - 20)
                    {
                        Console.Write(space);
                    }
                    Console.Write(" ");
                    Console.Write($"{map.FullMap[i, j].GetStatus}");
                }
            }
            MapManager.RemoveObjectFromMap(map, player.Position);

            Console.WriteLine("\n");
        }

        public static void MapName(Map map)
        {
            
            Console.WriteLine($"\t{map.Name}");
        }
        
        public static void DisplayPlayerDetails(Character player, Monster boss)
        {
            PLayerHealthAndPosition(player, boss);
            ShowLegend(player);
        }

        public static void EndGameLost()
        {
            Console.WriteLine("\n\n\n\tGAME OVER - YOU LOST\n\n\n");
        }

        public static void EndGameWon()
        {
            Console.WriteLine("\n\n\n\tGAME OVER - YOU WON\n\n\n");
        }

        public static void BossStatics(Monster boss)
        {
            Console.WriteLine($"\n{boss.Health}");
        }
    }
}
