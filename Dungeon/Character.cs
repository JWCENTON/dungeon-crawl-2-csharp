namespace Dungeon
{
    public abstract class Character
    {
        public virtual (int y, int x) Position { get; set; }
        public virtual string name { get; set; }
        public virtual int health { get; set; }
        public virtual int atackValue { get; set; }
        public virtual Equipment equipment { get; set; }
        public virtual bool isAlive { get; set; }
    }
}
