using Dungeon.Maps;
using Dungeon.Monsters;

namespace Dungeon
{
    public class Simulation
    {
        public void Move(Map map, Character player, List<Monster> monsters, CharacterManager manager)
        {
            MapManager.SetMonstersOnMap(map, monsters);
            Display.Map(map, player);
            Display.PLayerPosition(player);
            manager.GetPlayerMove(player, map);
            //Console.Clear();
            Console.WriteLine("\n\n");
            MapManager.RemoveMonstersFromMap(map, monsters);
        }
    }
}
