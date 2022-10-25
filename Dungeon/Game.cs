
namespace Dungeon
{
    public class Game
    {
        public void Play()
        {
            Map topFloor = new TopFloor();
            Map groundFloor = new GroundFloor();
            Character player = new Player();
            CharacterManager manager = new CharacterManager();

            while (true)
            {
                Display.Map(groundFloor, player);
                Display.PLayerPosition(player);
                manager.GetPlayerMove(player);
                Console.WriteLine("\n\n");
            }
        }
    }
}
