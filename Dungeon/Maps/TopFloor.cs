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
        private void PlaceStartIcon()
        {
            FullMap[10, 20] = new Square(Status.Start);
        }

        private void PlaceTree((int x, int y) startCoordinates)
        {
            Tree newTree = new Tree();
            //var startCoordinate = (13, 30);
            newTree.CreateTree(FullMap, startCoordinates);
        }

        private void CreateWallsAndEmptySpace(int i, int j)
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
        public void CreateMap()
        {
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    CreateWallsAndEmptySpace(i, j);
                }
            }
            PlaceStartIcon();
            PlaceTree((13, 30));
            PlaceTree((13, 33));
        }
    }
}
