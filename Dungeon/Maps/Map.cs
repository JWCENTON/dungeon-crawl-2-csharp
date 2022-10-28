namespace Dungeon.Maps
{
    public abstract class Map
    {
        public virtual string Name { get; }
        public readonly Square[,] FullMap;
        protected static int Width { get; private set; }
        public virtual int MapLevel { get; }

        protected Map()
        {
            Name = "map";
            Width = 80;
            FullMap = new Square[Width, Width];
            MapLevel = 0;
        }
    }
}
