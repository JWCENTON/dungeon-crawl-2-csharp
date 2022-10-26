﻿using Dungeon.Enum;

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
        private void PlaceStartIcon()
        {
            FullMap[10, 20] = new Square(Status.Start);
        }

        private void PlaceTree((int x, int y) startCoordinates)
        {
            var newTree = new Tree();
            newTree.CreateTree(FullMap, startCoordinates);
        }

        private void PlaceForest()
        {
            PlaceTree((13, 30));
            PlaceTree((13, 33));
            PlaceTree((20, 45));
            PlaceTree((23, 48));
            PlaceTree((24, 34));
            PlaceTree((34, 38));
            PlaceTree((37, 42));
            PlaceTree((53, 24));
            PlaceTree((54, 29));
            PlaceTree((54, 34));
        }

        private void PlaceCave()
        {
            var cave = new Cave();
            cave.CreateCave(FullMap, (53, 42));
        }


        private void CreateWallsAndEmptySpace(int row, int col)
        {
            if ((row == 9 || row == Width - 20) && col > 19 && col < Width - 20)
            {
                FullMap[row, col] = new Square(Status.UpDownWall);
            }

            else if ((col == 19 || col == Width - 20) && row >= 9 && row < Width - 19)
            {
                FullMap[row, col] = new Square(Status.SideWall);
            }
            else if (row >= 0 && row < 9 || row > Width - 20 && row <= Width ||
                     col >= 0 && col < 19 || col > Width - 20 && col <= Width)
            {
                FullMap[row, col] = new Square(Status.OutsideTopFloor);
            }
            else
            {
                FullMap[row, col] = new Square(Status.Empty);
            }
        }
        public void CreateMap()
        {
            for (var row = 0; row < Width; row++)
            {
                for (var col = 0; col < Width; col++)
                {
                    CreateWallsAndEmptySpace(row, col);
                }
            }
            PlaceStartIcon();
            PlaceForest();
            PlaceCave();
        }
    }
}
