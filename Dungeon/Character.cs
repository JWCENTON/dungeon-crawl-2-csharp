namespace Dungeon
{
    public abstract class Character
    {
        public (int y, int x) Position { get; set; }
        public string Name { get; set; }
        public virtual int Health { get; set; }
        public virtual int AtackValue { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual bool IsAlive { get; set; }
    }
}
