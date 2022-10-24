using Dungeon.Enum;

namespace Dungeon
{
    public abstract class Map
    {
        public Square[,] FullMap;
        public static int Width { get; private set; }

        public Map()
        {
            Width = 100;
            FullMap = new Square[Width, Width];
        }
    }
}
