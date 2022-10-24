using Dungeon.Enum;

namespace Dungeon
{
    public class GroundFloor : Map
    {
        public override string Name { get; }

        public GroundFloor()
        {
            Name = "bottom";
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
            FullMap[51, 4] = new Square(Status.Tree);
        }
    }
}
