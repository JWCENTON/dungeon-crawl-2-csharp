
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
                Display.Map(topFloor, player);
                Display.PLayerPosition(player);
                manager.GetPlayerMove(player, topFloor);
                //Console.Clear();
                Console.WriteLine("\n\n");
            }
        }
    }
}
