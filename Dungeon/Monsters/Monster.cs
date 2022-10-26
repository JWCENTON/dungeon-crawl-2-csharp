namespace Dungeon.Monsters
{
    public abstract class Monster
    {
        public virtual (int y, int x) Position { get; set; }
        public virtual string Name { get; }
        public virtual int Health { get; set; }
        public virtual int AtackValue { get; }
        public virtual string TypeAtack { get; }
        public virtual Item Item { get; set; }
        public int SetMonsterIntValue(int minHealth, int maxHealth)
        {
            Random random = new Random();

            return random.Next(minHealth, maxHealth);
        }
    }
}
