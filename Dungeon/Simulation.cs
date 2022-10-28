using Dungeon.Maps;
using Dungeon.Monsters;

namespace Dungeon
{
    public class Simulation
    {
        public void Move(Map map, Character player, List<Monster> monsters, CharacterManager manager, Monster boss)
        {
            MapManager.SetMonstersOnMap(map, monsters);
            Display.Map(map, player);
            Display.DisplayPlayerDetails(player);
            Equipment.ShowEquipment(player);
            manager.GetPlayerMove(player, map);
            player.EatApple();
            Console.Clear();
            Console.WriteLine("\n\n");
            MapManager.RemoveMonstersFromMap(map, monsters);
        }
    }
}
