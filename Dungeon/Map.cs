namespace Dungeon
{
    public class Map
    {
        public Square[,] FullMap;
        public int Width { get; }

        public Map()
        {
            Width = 11;
            FullMap = new Square[Width, Width];
            CreateMap();
        }

        private void CreateMap()
        {
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    FullMap[i, j] = new Square(Square.SquareStatus.Empty);
                }
            }
        }
    }
}
