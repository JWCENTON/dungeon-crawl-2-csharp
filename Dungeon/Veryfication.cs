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

        //private void RemoveKeyFromEquipment(Character character)
        //{
        //    var key = "K";
        //    var keyIndex = character.Equipment.IndexOf(key);
        //    character.Equipment.RemoveAt(keyIndex);
        //}
        //private void CheckKeyAndChangeLevel(string directionStatus, Character character)
        //{
        //    var entrance = 5;
        //    if (character.Equipment.Contains("K") && directionStatus == _walls[entrance])
        //    {
        //        character.Level = character.Level == "Top floor" ? "Ground floor" : "Top floor";
        //        RemoveKeyFromEquipment(character);
        //    }
        //}
        public bool DirectionUpIsWallOrChangeLevel(Map map, Character character)
        {
            var upDirectionStatus = map.FullMap[character.Position.x - 1, character.Position.y].GetStatus;
            var moveUp = (character.Position.y, character.Position.x - 1);
            LevelManager.CheckKeyAndChangeLevel(upDirectionStatus, character);
            if (ItIsWall(upDirectionStatus, _walls)) return false;
            character.Position = moveUp;
            return true;
        }

        public bool DirectionDownIsWallOrChangeLevel(Map map, Character character)
        {
            var downDirectionStatus = map.FullMap[character.Position.x + 1, character.Position.y].GetStatus;
            var moveDown = (character.Position.y, character.Position.x + 1);
            LevelManager.CheckKeyAndChangeLevel(downDirectionStatus, character);
            if (ItIsWall(downDirectionStatus, _walls)) return false;
            character.Position = moveDown;
            return true;
        }

        public bool DirectionLeftIsWallOrChangeLevel(Map map, Character character)
        {
            var leftDirectionStatus = map.FullMap[character.Position.x, character.Position.y - 1].GetStatus;
            var moveLeft = (character.Position.y - 1, character.Position.x);
            LevelManager.CheckKeyAndChangeLevel(leftDirectionStatus, character);
            if (ItIsWall(leftDirectionStatus, _walls)) return false;
            character.Position = moveLeft;
            return true;
        }

        public bool DirectionRightIsWallOrChangeLevel(Map map, Character character)
        {
            var rightDirectionStatus = map.FullMap[character.Position.x, character.Position.y + 1].GetStatus;
            var moveRight = (character.Position.y + 1, character.Position.x);
            LevelManager.CheckKeyAndChangeLevel(rightDirectionStatus, character);
            if (ItIsWall(rightDirectionStatus, _walls)) return false;
            character.Position = moveRight;
            return true;
        }
    }
}
