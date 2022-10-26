using Dungeon.Enum;

namespace Dungeon.Maps
{
    public class TopFloor : Map
    {
        public override string Name { get; }

        public TopFloor()
        {
            Name = "Top floor";
            CreateMap();
        }

        private void StartName()
        {
            FullMap[10, 20] = new Square(Status.Start);
        }

        private void Tree()
        {
            FullMap[18, 30] = new Square(Status.Tree);
            FullMap[18, 31] = new Square(Status.Tree);
            FullMap[17, 30] = new Square(Status.Tree);
            FullMap[17, 31] = new Square(Status.Tree);
            FullMap[16, 30] = new Square(Status.Tree);
            FullMap[16, 31] = new Square(Status.Tree);
            FullMap[15, 29] = new Square(Status.UpDownWall);
            FullMap[15, 30] = new Square(Status.UpDownWall);
            FullMap[15, 31] = new Square(Status.UpDownWall);
            FullMap[15, 32] = new Square(Status.UpDownWall);
            FullMap[14, 29] = new Square(Status.UpDownWall);
            FullMap[14, 30] = new Square(Status.UpDownWall);
            FullMap[14, 31] = new Square(Status.UpDownWall);
            FullMap[14, 32] = new Square(Status.UpDownWall);
            FullMap[13, 30] = new Square(Status.UpDownWall);
            FullMap[13, 31] = new Square(Status.UpDownWall);
        }
        public void CreateMap()
        {
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    if ((i == 9 || i == Width - 20) && j > 19 && j < Width - 20)
                    {
                        FullMap[i, j] = new Square(Status.UpDownWall);
                    }

                    else if ((j == 19 || j == Width - 20) && i >= 9 && i < Width - 19)
                    {
                        FullMap[i, j] = new Square(Status.SideWall);
                    }
                    else if (i >= 0 && i < 9 || i > Width - 20 && i <= Width ||
                             j >= 0 && j < 19 || j > Width - 20 && j <= Width)
                    {
                        FullMap[i, j] = new Square(Status.OutsideTopFloor);
                    }
                    else
                    {
                        FullMap[i, j] = new Square(Status.Empty);
                    }
                }
            }
            StartName();
            Tree();
        }
    }
}
