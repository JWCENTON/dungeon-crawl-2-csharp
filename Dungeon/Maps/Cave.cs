

using Dungeon.Enum;

namespace Dungeon.Maps
{
    public class Cave
    {
        private readonly Square _caveWallLeft = new Square(Status.CaveLeftWall);
        private readonly Square _caveWallRight = new Square(Status.CaveRightWall);
        private void CreateWalLeftBend(Square[,] map, (int x, int y) firstTopCoordinate)
        {
            var x = firstTopCoordinate.x;
            var y = firstTopCoordinate.y;
            map[x, y] = _caveWallLeft;
            map[x, y + 3] = _caveWallLeft;
            map[x, y + 13] = _caveWallLeft;
            map[x + 1, y + 1] = _caveWallLeft;
            map[x + 1, y + 14] = _caveWallLeft;
            map[x + 4, y + 11] = _caveWallLeft;
            map[x + 5, y] = _caveWallLeft;
            map[x - 1, y + 12] = _caveWallLeft;
            map[x - 1, y + 10] = _caveWallLeft;
            map[x - 1, y + 8] = _caveWallLeft;
            map[x - 1, y + 2] = _caveWallLeft;
        }

        private void CreateWalRightBend(Square[,] map, (int x, int y) firstTopCoordinate)
        {
            var x = firstTopCoordinate.x;
            var y = firstTopCoordinate.y;
            map[x - 1, y + 1] = _caveWallRight;
            map[x - 1, y + 11] = _caveWallRight;
            map[x - 1, y + 9] = _caveWallRight;
            map[x - 1, y + 7] = _caveWallRight;
            map[x, y + 6] = _caveWallRight;
            map[x + 2, y + 1] = _caveWallRight;
            map[x + 2, y + 14] = _caveWallRight;
            map[x + 3, y] = _caveWallRight;
            map[x + 3, y + 13] = _caveWallRight;
            map[x + 4, y - 1] = _caveWallRight;
            map[x + 4, y + 10] = _caveWallRight;
            map[x + 4, y + 12] = _caveWallRight;
            map[x + 5, y + 9] = _caveWallRight;
            map[x + 6, y + 1] = _caveWallRight;

            for (var yCor = 1; yCor <= 8; yCor++)
            {
                map[x + 6, y + yCor] = _caveWallRight;
            }
        }

        private void CreateEntrance(Square[,] map, (int x, int y) firstTopCoordinate)
        {
            var x = firstTopCoordinate.x;
            var y = firstTopCoordinate.y;
            map[x + 1, y + 5] = new Square(Status.Entrance);
            map[x + 1, y + 4] = new Square(Status.Entrance);
        }

        public void CreateCave(Square[,] map, (int x, int y) firstTopCoordinate)
        {
            CreateWalLeftBend(map, firstTopCoordinate);
            CreateWalRightBend(map, firstTopCoordinate);
            CreateEntrance(map, firstTopCoordinate);
        }
    }
}
