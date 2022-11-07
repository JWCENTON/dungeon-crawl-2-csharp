using System.Runtime.InteropServices;
using Dungeon.Enum;
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

            Character player = new Alice();

            CharacterManager manager = new CharacterManager();
            var boss = manager.CreateMonster(Status.Boss);
            _monsters = manager.CreateListOfMonsters(3);

            _monsters.Add(boss);

            Simulation simulation = new();
            var play = true;
            while (play)
            {
                simulation.Move(player.Level == "Top floor" ? topFloor : groundFloor, player, _monsters, manager, boss);
                play = EndGame.CheckForEndGame(player, (Boss)boss);
            }
        }
    }
}
