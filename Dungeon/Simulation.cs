using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dungeon.Enum;
using Dungeon.Maps;
using Dungeon.Monsters;

namespace Dungeon
{
    public class Simulation
    {
        private void Turn(Map map, Character player, List<Monster> monsters, CharacterManager manager, Monster boss)
        {
            MapManager.SetMonstersOnMap(map, monsters);
            Display.Map(map, player);
            Display.DisplayPlayerDetails(player, boss);
            Equipment.ShowEquipment(player);
            manager.GetPlayerMove(player, map);
            manager.GetBossMove(boss, map);
            player.EatApple();
            Console.WriteLine("\n\n");
            MapManager.RemoveMonstersFromMap(map, monsters);
            Console.Clear();
        }
        public void Move(Map map, Character player, List<Monster> monsters, CharacterManager manager, Monster boss)
        {
            Turn(map, player, monsters, manager, boss);
        }
    }
}
