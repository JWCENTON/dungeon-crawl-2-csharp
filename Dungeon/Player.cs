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
            Position = (50, 5);
        }
    }
}
