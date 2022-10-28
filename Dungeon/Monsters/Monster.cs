using Dungeon.Enum;

namespace Dungeon.Monsters
{
    public abstract class Monster
    {
        public (int y, int x) Position { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public Status Type { get; set; }
        public int Health { get; set; }
        public int AtackValue { get; set; }
        public string TypeAtack { get; set; }
        public Item Item { get; set; }
        public bool IsAlive { get; set; }
        public virtual int MapLevel {get; }
        internal int SetMonsterIntValue(int minHealth, int maxHealth)
        {
            Random random = new Random();

            return random.Next(minHealth, maxHealth);
        }
    }
}
