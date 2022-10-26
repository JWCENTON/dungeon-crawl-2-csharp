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
        public void CreateTree(Square[,] map)
        {
            map[18, 30] = new Square(Status.Tree);
            map[18, 31] = new Square(Status.Tree);
            map[17, 30] = new Square(Status.Tree);
            map[17, 31] = new Square(Status.Tree);
            map[16, 30] = new Square(Status.Tree);
            map[16, 31] = new Square(Status.Tree);
            map[15, 29] = new Square(Status.UpDownWall);
            map[15, 30] = new Square(Status.UpDownWall);
            map[15, 31] = new Square(Status.UpDownWall);
            map[15, 32] = new Square(Status.UpDownWall);
            map[14, 29] = new Square(Status.UpDownWall);
            map[14, 30] = new Square(Status.UpDownWall);
            map[14, 31] = new Square(Status.UpDownWall);
            map[14, 32] = new Square(Status.UpDownWall);
            map[13, 30] = new Square(Status.UpDownWall);
            map[13, 31] = new Square(Status.UpDownWall);
        }
    }
}
