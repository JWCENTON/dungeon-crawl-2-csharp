using System.ComponentModel.DataAnnotations;

namespace Dungeon
{
    public class Game
    {
        public void Play()
        {
            Map map = new Map();
            Display.Floor();
        }
    }
}
