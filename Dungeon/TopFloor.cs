using Dungeon.Enum;

namespace Dungeon
{
    public class TopFloor : Map
    {
        public override string Name { get; }

        public TopFloor()
        {
            Name = "top";
            CreateMap();
        }

        public void CreateMap()
        {
            int counter = 0;
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    if ((i == 9 || i == Width - 20) && (j > 19 && j < Width - 20))
                    {
                        FullMap[i, j] = new Square(Status.UpDownWall);
                    }

                    else if ((j == 19 || j == Width - 20) && (i >= 9 && i < Width - 19))
                    {
                        FullMap[i, j] = new Square(Status.SideWall);
                    }
                    else if ((i >= 0 && i < 10) || (i > Width - 20 && i <= Width) ||
                             (j >= 0 && j < 20) || (j > Width - 20 && j <= Width))
                    {
                        FullMap[i, j] = new Square(Status.Outside);
                    }
                    else
                    {
                        FullMap[i, j] = new Square(Status.Empty);
                    }
                }
            }
            //FullMap[100, 100] = new Square(Status.Tree);
        }
    }
}
