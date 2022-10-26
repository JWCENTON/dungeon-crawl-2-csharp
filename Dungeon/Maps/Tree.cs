using Dungeon.Enum;

namespace Dungeon.Maps
{
    public class Tree
    {
        private void CreateTreeLeg(Square[,] map, (int x, int y) first)
        {
            var leftLeg = first.y;
            var rightLeg = first.y + 1;
            (int firstRow, int endRow) leg = (first.x + 3, first.x + 5);
            var treeLeg = new Square(Status.Tree);

            for (var i = leg.firstRow; i <= leg.endRow; i++)
            {
                for (var j = leftLeg; j <= rightLeg; j++)
                {
                    map[i, j] = treeLeg;
                }
            }
        }

        private void CreateTreeHead(Square[,] map, (int x, int y) first)
        {
            var head = new Square(Status.UpDownWall);

            map[first.x, first.y] = head;
            map[first.x, first.y + 1] = head;
            for (var i = first.x + 1; i <= first.x + 2; i++)
            {
                for (var j = first.y - 1; j <= first.y + 2; j++)
                {
                    map[i, j] = head;
                }
            }
        }

        public void CreateTree(Square[,] map, (int x, int y) first)
        {
            CreateTreeLeg(map, first);
            CreateTreeHead(map, first);
        }
    }
}
