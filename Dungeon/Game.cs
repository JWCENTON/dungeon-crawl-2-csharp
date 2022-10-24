using System.ComponentModel.DataAnnotations;

namespace Dungeon
{
    public class Game
    {
        public void Play()
        {
            Map floorMap = new TopFloor();
            Player player = new Player();
            Display.Map(floorMap, player);
        }
    }
}
