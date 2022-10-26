

using Dungeon.Enum;

namespace Dungeon.Maps
{
    public class Cave
    {
        public void CreateCave(Square[,] map, (int x, int y) firstTopCoordinate)
        {
            var caveWallLeft = new Square(Status.CaveLeftWall);
            var caveWallRight = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x, firstTopCoordinate.y] = new Square(Status.CaveLeftWall);
            map[firstTopCoordinate.x + 1, firstTopCoordinate.y + 1] = new Square(Status.CaveLeftWall);
            map[firstTopCoordinate.x - 1, firstTopCoordinate.y + 1] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 2, firstTopCoordinate.y + 1] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 3, firstTopCoordinate.y] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 4, firstTopCoordinate.y - 1] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 5, firstTopCoordinate.y] = new Square(Status.CaveLeftWall);
            map[firstTopCoordinate.x + 6, firstTopCoordinate.y + 1] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 5, firstTopCoordinate.y] = new Square(Status.CaveLeftWall);

            map[firstTopCoordinate.x + 6, firstTopCoordinate.y + 1] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 6, firstTopCoordinate.y + 2] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 6, firstTopCoordinate.y + 3] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 6, firstTopCoordinate.y + 4] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 6, firstTopCoordinate.y + 5] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 6, firstTopCoordinate.y + 6] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 6, firstTopCoordinate.y + 7] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 6, firstTopCoordinate.y + 8] = new Square(Status.CaveRightWall);

            map[firstTopCoordinate.x + 5, firstTopCoordinate.y + 9] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 4, firstTopCoordinate.y + 10] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 4, firstTopCoordinate.y + 11] = new Square(Status.CaveLeftWall);
            map[firstTopCoordinate.x + 4, firstTopCoordinate.y + 12] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 3, firstTopCoordinate.y + 13] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 2, firstTopCoordinate.y + 14] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x + 1, firstTopCoordinate.y + 14] = new Square(Status.CaveLeftWall);
            map[firstTopCoordinate.x, firstTopCoordinate.y + 13] = new Square(Status.CaveLeftWall);
            map[firstTopCoordinate.x - 1, firstTopCoordinate.y + 12] = new Square(Status.CaveLeftWall);
            map[firstTopCoordinate.x - 1, firstTopCoordinate.y + 11] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x - 1, firstTopCoordinate.y + 10] = new Square(Status.CaveLeftWall);

            map[firstTopCoordinate.x - 1, firstTopCoordinate.y + 9] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x - 1, firstTopCoordinate.y + 8] = new Square(Status.CaveLeftWall);
            map[firstTopCoordinate.x - 1, firstTopCoordinate.y + 7] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x, firstTopCoordinate.y + 6] = new Square(Status.CaveRightWall);
            map[firstTopCoordinate.x - 1, firstTopCoordinate.y + 2] = new Square(Status.CaveLeftWall);
            map[firstTopCoordinate.x, firstTopCoordinate.y + 3] = new Square(Status.CaveLeftWall);

        }
    }
}
