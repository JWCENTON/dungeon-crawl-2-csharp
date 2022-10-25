namespace Dungeon
{
    public class Player
    {
        public (int x, int y) Position { get; set; }
        public string name { get; set; }
        public int health { get; set; }
        public int atack { get; set; }
        public Equipment equipment { get; set; }

        public Player()
        {
            Position = (10, 20); // Players corner positions: Left top 10, 20 | left bottom 379, 20 | right top 10, 379 | right bottom 379, 379
        }

    }
}
