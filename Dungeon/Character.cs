using Dungeon.Enum;

namespace Dungeon
{
    public abstract class Character
    {
        public (int y, int x) Position { get; set; }
        public string Name { get; set; }
        public Status Type { get; set; }
        public string? Level { get; set; }
        public virtual int Health { get; set; }
        public virtual List<string> Equipment { get; set; }

        public virtual int AtackValue { get; set; }
        public virtual bool IsAlive { get; set; }

        public bool ShowEquipment { get; set; }

        public virtual void EatApple ()
        {
        }
    
    }
}
