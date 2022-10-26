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
            
            Simulation simulation = new();

            while (true)
            {
                simulation.Move(player.Level == "Top floor" ? topFloor : groundFloor, player, _monsters, manager);
                Console.WriteLine($" eq count : {player.Equipment.Count}");
            }
        }
    }
}
