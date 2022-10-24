using Dungeon.Enum;

namespace Dungeon
{
    public class TopFloor : Map
    {
        public TopFloor() : base()
        {

            CreateMap();
        }

        public void CreateMap()
        {
            for (var i = 0; i < Map.Width; i++)
            {
                for (var j = 0; j < Map.Width; j++)
                {
                    FullMap[i, j] = new Square(Status.Empty);
                }
            }
            FullMap[49, 4] = new Square(Status.Tree);
        }
    }
}
