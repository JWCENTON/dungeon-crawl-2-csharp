using Dungeon.Enum;

namespace Dungeon
{
    public class Square
    {
        public Status Status { get; }
        public string GetStatus { get; }

        public Square(Status status)
        {
            Status = status;
            GetStatus = GetSquareStatus(status);
        }

        public string GetSquareStatus(Status status) //         Player,Empty,Tree,UpperWall,LowerWall
        {
            if (status == Status.Player)
            {
                return "P";
            }
            else if (status == Status.Tree)
            {
                return "T";
            }
            else if (status == Status.UpperWall)
            {
                return "-";
            }
            else if (status == Status.LowerWall)
            {
                return "T";
            }
            else
            {
                return ".";
            }
        }
    }
}
