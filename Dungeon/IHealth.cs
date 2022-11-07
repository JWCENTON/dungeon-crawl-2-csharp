namespace Dungeon
{
    public interface IHealth
    {
        public int Health
        {
            get;
            set;
        }

        public bool IsAlive
        {
            get;
            set;
        }
    }
}
