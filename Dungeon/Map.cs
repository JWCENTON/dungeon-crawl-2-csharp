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
            //CreateMap();
        }

        //private void CreateMap()
        //{
        //    for (var i = 0; i < Width; i++)
        //    {
        //        for (var j = 0; j < Width; j++)
        //        {
        //            FullMap[i, j] = new Square(Status.Empty);
        //        }
        //    }
        //}
    }
}
