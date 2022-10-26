using Dungeon.Enum;
using Dungeon.Maps;

namespace Dungeon
{
    public class Verification
    {
        private readonly List<string> _walls = new() { "=", "|", "||", "/", "\\", "#", "^" };

        private static bool ItIsWall(string direction,List<string> _walls)
        {
            foreach (var wall in _walls)
            {
                if (direction == wall)
                {
                    return true;
                }
            }

            return false;
        }
        private void CheckAndChangeLevel(string directionStatus, Character character)
        {
            if (directionStatus != _walls[5]) return;
            character.Level = character.Level == "Top floor" ? "Ground floor" : "Top floor";
        }
        public bool DirectionUpIsWallOrChangeLevel(Map map, Character character)
        {
            var upDirectionStatus = map.FullMap[character.Position.x - 1, character.Position.y].GetStatus;
            var moveUp = (character.Position.y, character.Position.x - 1);
            CheckAndChangeLevel(upDirectionStatus, character);
            if (ItIsWall(upDirectionStatus, _walls)) return false;
            character.Position = moveUp;
            return true;
        }

        public bool DirectionDownIsWallOrChangeLevel(Map map, Character character)
        {
            var downDirectionStatus = map.FullMap[character.Position.x + 1, character.Position.y].GetStatus;
            var moveDown = (character.Position.y, character.Position.x + 1);
            CheckAndChangeLevel(downDirectionStatus, character);
            if (ItIsWall(downDirectionStatus, _walls)) return false;
            character.Position = moveDown;
            return true;
        }

        public bool DirectionLeftIsWallOrChangeLevel(Map map, Character character)
        {
            var leftDirectionStatus = map.FullMap[character.Position.x, character.Position.y - 1].GetStatus;
            var moveLeft = (character.Position.y - 1, character.Position.x);
            CheckAndChangeLevel(leftDirectionStatus, character);
            if (ItIsWall(leftDirectionStatus, _walls)) return false;
            character.Position = moveLeft;
            return true;
        }

        public bool DirectionRightIsWallOrChangeLevel(Map map, Character character)
        {
            var rightDirectionStatus = map.FullMap[character.Position.x, character.Position.y + 1].GetStatus;
            var moveRight = (character.Position.y + 1, character.Position.x);
            CheckAndChangeLevel(rightDirectionStatus, character);
            if (ItIsWall(rightDirectionStatus, _walls)) return false;
            character.Position = moveRight;
            return true;
        }
    }
}
