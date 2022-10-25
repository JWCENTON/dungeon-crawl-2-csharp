namespace Dungeon
{
    public class Player : Character
    {
        public (int y, int x) Position { get; set; }
        public string name { get; set; }
        public int health { get; set; }
        public int atack { get; set; }
        public Equipment equipment { get; set; }

        public Player()
        {
            Position = (21, 11);
        }

    }
}
