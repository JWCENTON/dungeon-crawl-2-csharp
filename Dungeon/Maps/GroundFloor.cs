using Dungeon.Enum;
using Dungeon.Monsters;

namespace Dungeon.Maps
{
    public class GroundFloor : Map
    {
        public override string Name { get; }
        private readonly Random _rd = new ();
        public override int MapLevel { get; }
        
        public GroundFloor()
        {
            Name = "Ground floor";
            CreateMap();
            MapLevel = 2;
        }

        private void PlaceBossCave()
        {
            FullMap[32, 37] = new Square(Status.UpDownWall);
            FullMap[32, 38] = new Square(Status.UpDownWall);
            FullMap[32, 39] = new Square(Status.UpDownWall);
            FullMap[32, 40] = new Square(Status.UpDownWall);
            FullMap[32, 41] = new Square(Status.UpDownWall);
            FullMap[32, 42] = new Square(Status.UpDownWall);

            FullMap[35, 37] = new Square(Status.UpDownWall);
            FullMap[35, 38] = new Square(Status.UpDownWall);
            FullMap[35, 41] = new Square(Status.UpDownWall);
            FullMap[35, 42] = new Square(Status.UpDownWall);


            FullMap[32, 43] = new Square(Status.SideWall);
            FullMap[33, 43] = new Square(Status.SideWall);
            FullMap[34, 43] = new Square(Status.SideWall);
            FullMap[35, 43] = new Square(Status.SideWall);

            FullMap[32, 36] = new Square(Status.SideWall);
            FullMap[33, 36] = new Square(Status.SideWall);
            FullMap[34, 36] = new Square(Status.SideWall);
            FullMap[35, 36] = new Square(Status.SideWall);
        }

        private void PlaceRocks()
        {
            var totalRocks = 50;
            for (var rockNumber = 0; rockNumber <= totalRocks; rockNumber++)
            {
                var newX = _rd.Next(11, 69);
                var newY = _rd.Next(21, 59);
                FullMap[newX, newY] = new Square(Status.OutsideTopFloor);
            }
            FullMap[37, 39] = new Square(Status.OutsideTopFloor);
            FullMap[37, 40] = new Square(Status.OutsideTopFloor);
            FullMap[38, 39] = new Square(Status.OutsideTopFloor);
            FullMap[38, 40] = new Square(Status.OutsideTopFloor);
        }
        private void PlaceCave()
        {
            var cave = new Cave();
            cave.CreateCave(FullMap, (53, 42));
        }

        private void PlaceApples()
        {
            Random rd = new Random();

            var numberOfApples = 5;
            for (var apple = 0; apple <= numberOfApples; apple++)
            {
                var x = rd.Next(40, 51);
                var y = rd.Next(21, 40);
                FullMap[x, y] = new Square(Status.Apple);
            }
            FullMap[12, 24] = new Square(Status.Apple);
            FullMap[11, 54] = new Square(Status.Apple);
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
                    else if (i >= 0 && i < 10 || i > Width - 20 && i <= Width ||
                             j >= 0 && j < 20 || j > Width - 20 && j <= Width)
                    {
                        FullMap[i, j] = new Square(Status.OutsideGroundFloor);
                    }
                    else
                    {
                        FullMap[i, j] = new Square(Status.Empty);
                    }
                }
            }
            PlaceRocks();
            PlaceCave();
            PlaceApples();
            PlaceBossCave();
        }
    }
}
