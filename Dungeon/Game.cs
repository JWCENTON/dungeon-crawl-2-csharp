
namespace Dungeon
{
    public class Game
    {
        public void Play()
        {
            Map topFloor = new TopFloor();
            Map groundFloor = new GroundFloor();
            Player player = new Player();
            Display.Map(topFloor, player);
            Display.Map(groundFloor, player);
            Display.MapName(topFloor);
            Display.MapName(groundFloor);
        }
    }
}
