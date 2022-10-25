namespace Dungeon
{
    public abstract class Map
    {
        public virtual string Name { get; }
        public readonly Square[,] FullMap;
        protected static int Width { get; private set; }

        public Map()
        {
            Name = "map";
            Width = 100;
            FullMap = new Square[Width, Width];
        }
    }
}
