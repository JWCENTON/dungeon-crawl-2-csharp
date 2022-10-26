using Dungeon.Enum;

namespace Dungeon.Maps
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
            else if (status == Status.Monster1)
            {
                return "1";
            }
            else if (status == Status.Monster2)
            {
                return "2";
            }
            else if (status == Status.Monster3)
            {
                return "3";
            }
            else if (status == Status.CaveLeftWall)
            {
                return "\\";
            }
            else if (status == Status.CaveRightWall)
            {
                return "/";
            }
            else if (status == Status.Entrance)
            {
                return "#";
            }
            else if (status == Status.Key)
            {
                return "K";
            }
            else
            {
                return " ";
            }
        }
    }
}
