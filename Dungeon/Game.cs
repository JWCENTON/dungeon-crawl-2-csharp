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
                if (player.Level == "Top floor")
                {
                    MapManager.SetMonstersOnMap(topFloor, _monsters);

                    Display.Map(topFloor, player);
                    Display.PLayerPosition(player);
                    manager.GetPlayerMove(player, topFloor);
                    //Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine($"{player.Level}");
                    MapManager.RemoveMonstersFromMap(topFloor, _monsters);
                }
                else
                {
                    MapManager.SetMonstersOnMap(groundFloor, _monsters);

                    Display.Map(groundFloor, player);
                    Display.PLayerPosition(player);
                    manager.GetPlayerMove(player, groundFloor);
                    //Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine($"{player.Level}");
                    MapManager.RemoveMonstersFromMap(groundFloor, _monsters);
                }

                //MapManager.SetMonstersOnMap(topFloor, _monsters);

                //Display.Map(topFloor, player);
                //Display.PLayerPosition(player);
                //manager.GetPlayerMove(player, topFloor);
                //Console.Clear();
                //Console.WriteLine("\n\n");
                //MapManager.RemoveMonstersFromMap(topFloor, _monsters);
            }
        }
    }
}
