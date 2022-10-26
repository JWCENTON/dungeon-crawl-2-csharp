using System.Threading.Channels;

namespace Dungeon
{
    public class Verification
    {
        private readonly List<string> _walls = new List<string>{"=", "|", "||"};

        public bool DirectionUpIsWall(Map map, Character character)
        {
            var upDirectionStatus = map.FullMap[character.Position.x - 1, character.Position.y].GetStatus;
            var moveUp = (character.Position.y, character.Position.x - 1);
            foreach (var wall in _walls)
            {
                if (upDirectionStatus == wall)
                {
                    return false;
                }
            }
            character.Position = moveUp;
            return true;
        }

        public bool DirectionDownIsWall(Map map, Character character)
        {
            var downDirectionStatus = map.FullMap[character.Position.x + 1, character.Position.y].GetStatus;
            var moveDown = (character.Position.y, character.Position.x + 1);
            foreach (var wall in _walls)
            {
                if (downDirectionStatus == wall)
                {
                    return false;
                }
            }
            character.Position = moveDown;
            return true;
        }

        public bool DirectionLeftIsWall(Map map, Character character)
        {
            var leftDirectionStatus = map.FullMap[character.Position.x, character.Position.y - 1].GetStatus;
            var moveLeft = (character.Position.y - 1, character.Position.x);
            foreach (var wall in _walls)
            {
                if (leftDirectionStatus == wall)
                {
                    return false;
                }
            }
            character.Position = moveLeft;
            return true;
        }

        public bool DirectionRightIsWall(Map map, Character character)
        {
            var rightDirectionStatus = map.FullMap[character.Position.x, character.Position.y + 1].GetStatus;
            var moveRight = (character.Position.y + 1, character.Position.x);
            //if (map.FullMap[character.Position.x, character.Position.y + 1].GetStatus != "||" &&
            //    map.FullMap[character.Position.x, character.Position.y + 1].GetStatus != "=" &&
            //    map.FullMap[character.Position.x, character.Position.y + 1].GetStatus != "|")
            foreach (var wall in _walls)
            {
                if (rightDirectionStatus == wall)
                {
                    return false;
                }
            }
            character.Position = moveRight;
            return true;
        }
    }
}
