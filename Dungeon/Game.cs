using Dungeon.Maps;
using Dungeon.Monsters;

namespace Dungeon
{
    public class Game
    {
        private List<Monster> _monsters = new();
        public void Play()
        {
            Map topFloor = new TopFloor();
            Map groundFloor = new GroundFloor();
            Character player = new Player();
            CharacterManager manager = new CharacterManager();
            _monsters = manager.CreateListOfMonsters(1);


            while (true)
            {
                MapManager.SetMonstersOnMap(topFloor, _monsters);
                Display.Map(topFloor, player);
                Display.PLayerPosition(player);
                manager.GetPlayerMove(player, topFloor);
                Console.Clear();
                Console.WriteLine("\n\n");
                MapManager.RemoveMonstersFromMap(topFloor, _monsters);
            }
        }
    }
}
