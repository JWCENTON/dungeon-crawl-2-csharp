﻿using Dungeon.Enum;

namespace Dungeon.Maps
{
    public class GroundFloor : Map
    {
        public override string Name { get; }

        public GroundFloor()
        {
            Name = "Ground floor";
            CreateMap();
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
            FullMap[13, 23] = new Square(Status.Tree);
        }
    }
}