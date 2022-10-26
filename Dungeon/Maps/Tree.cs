using Dungeon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Maps
{
    public class Tree
    {
        private void CreateTreeLeg(Square[,] map, (int x, int y) start) // 13, 30
        {
            var leftLeg = start.y;
            var rightLeg = start.y + 1;
            (int startRow, int endRow) leg = (start.x + 3, start.x + 5);
            var treeLeg = new Square(Status.Tree);

            for (var i = leg.startRow; i <= leg.endRow; i++)
            {
                for (var j = leftLeg; j <= rightLeg; j++)
                {
                    map[i, j] = treeLeg;
                }
            }
        }

        private void CreateTreeHead(Square[,] map, (int x, int y) start)
        {
            var head = new Square(Status.UpDownWall);

            map[start.x, start.y] = head;
            map[start.x, start.y + 1] = head;
            for (var i = start.x + 1; i <= start.x + 2; i++)
            {
                for (var j = start.y - 1; j <= start.y + 2; j++)
                {
                    map[i, j] = head;
                }
            }
        }

        public void CreateTree(Square[,] map, (int x, int y) start) // 13,30
        {
            CreateTreeLeg(map, start);
            CreateTreeHead(map, start);
        }
    }
}
