namespace Dungeon
{
    internal class Player : Character
    {
        public (int, int) position { get; set; }
        public string name { get; set; }
        public int health { get; set; }
        public int atack { get; set; }
        public Equipment equipment { get; set; }

    }
}
