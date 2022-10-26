﻿using Dungeon.Enum;

namespace Dungeon.Maps
{
    public class GroundFloor : Map
    {
        public override string Name { get; }
        private Random _rd = new Random();
        
        public GroundFloor()
        {
            Name = "Ground floor";
            CreateMap();
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
        }
        private void PlaceCave()
        {
            var cave = new Cave();
            cave.CreateCave(FullMap, (53, 42));
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
        }
    }
}
