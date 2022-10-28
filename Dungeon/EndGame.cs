using Dungeon.Monsters;

namespace Dungeon
{
    public class EndGame
    {
        public static bool CheckForEndGame(Character player, Boss boss)
        {
            if (player.Health <= 1)
            {
                Display.EndGameLost();
                return false;
            }
            else if (boss.Health <= 1)
            {
                Display.EndGameWon();
                return false;
            }
            return true;
        }
    }
}
