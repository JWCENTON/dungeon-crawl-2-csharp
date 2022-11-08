using System.Runtime.InteropServices;
using Dungeon.Enum;
using Dungeon.Maps;
using Dungeon.Monsters;
using Dungeon.Menu;

namespace Dungeon
{
    public class Game
    {
        private List<Monster> _monsters = new();

        public void Play()
        {
            Map topFloor = new TopFloor();
            Map groundFloor = new GroundFloor();
            MenuManager managerMenu = new MenuManager();

            CharacterManager manager = new CharacterManager();
            var boss = manager.CreateMonster(Status.Boss);
            _monsters = manager.CreateListOfMonsters(10);

            _monsters.Add(boss);

            Simulation simulation = new();
            var play = true;

            PlayMenu();
            Character player = managerMenu.CreateCharacter();
            while (play)
            {
                simulation.Move(player.Level == "Top floor" ? topFloor : groundFloor, player, _monsters, manager, boss);
                play = EndGame.CheckForEndGame(player, (Boss)boss);
            }

            void PlayMenu()
            {
               
                while (!managerMenu.start)
                {
                    Display.ClearConsole();
                    Display.DisplayRow(Ascii.textMenu);
                    var key = Console.ReadKey().KeyChar;
                    managerMenu.Manager(key);
                }
            }
        }
    }
}
