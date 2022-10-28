using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class EndGame
    {
        public static bool CheckForEndGame(Character player)
        {
            if (player.Health <= 1)
            {
                Display.EndGame();
                return false;
            }

            return true;
        }
    }
}
