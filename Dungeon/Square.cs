namespace Dungeon
{
    public class Square
    {
        private SquareStatus Status { get; set; }
        public string SqStatus { get; set; }

        public Square(SquareStatus status)
        {
            Status = status;
            SqStatus = GetCharacterSquareStatus(status);
        }

        public enum SquareStatus
        {
            Player, Empty, Tree
        }

        public string GetCharacterSquareStatus(SquareStatus status)
        {
            if (status == SquareStatus.Player)
            {
                return "P";
            }
            else if (status == SquareStatus.Tree)
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
