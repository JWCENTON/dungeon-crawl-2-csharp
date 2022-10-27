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
            _monsters = manager.CreateListOfMonsters(3);
            
            Simulation simulation = new();
            var play = true;
            while (play)
            {
                simulation.Move(player.Level == "Top floor" ? topFloor : groundFloor, player, _monsters, manager);
                play = EndGame.CheckForEndGame(player);
            }
        }
    }
}
