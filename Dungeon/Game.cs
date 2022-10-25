
namespace Dungeon
{
    public class Game
    {
        public void Play()
        {
            Map topFloor = new TopFloor();
            Map groundFloor = new GroundFloor();
            Player player = new Player();
            CharacterManager manager = new CharacterManager();

            while (true)
            {
                Display.Map(topFloor, player);
                Display.PLayerPosition(player);
                manager.MakeMove(player);
                Console.Clear();
                Console.WriteLine("\n\n");
            }
            
        }
    }
}
