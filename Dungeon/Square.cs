using Dungeon.Enum;

namespace Dungeon
{
    public class Square
    {
        public string GetStatus { get; }

        public Square(Status status)
        {
            GetStatus = GetSquareStatus(status);
        }

        private string GetSquareStatus(Status status)
        {
            if (status == Status.Player)
            {
                return "P";
            }
            else if (status == Status.Tree)
            {
                return "|";
            }
            else if (status == Status.UpDownWall)
            {
                return "=";
            }
            else if (status == Status.SideWall)
            {
                return "||";
            }
            else if (status == Status.OutsideTopFloor)
            {
                return "^";
            }
            else if (status == Status.OutsideGroundFloor)
            {
                return "\u2580"; // ■
            }
            else if (status == Status.Start)
            {
                return ">";
            }
            else
            {
                return " ";
            }
        }
    }
}
