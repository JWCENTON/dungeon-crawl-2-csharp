using Dungeon.Enum;
using Dungeon.Maps;
using Dungeon.Monsters;
using System.Numerics;

namespace Dungeon
{
    public class Verification
    {
        private static List<string> _walls = new() { "=", "|", "||", "/", "\\", "#", "^" };

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

        public static bool IsMonsterNearby(Character player, Map map)
        {
            int xCoordinate = player.Position.x;
            int yCoordinate = player.Position.y;
            List<string> monsterStatusList = new List<string> { "1", "2", "3", "B" };

            if (monsterStatusList.Contains(map.FullMap[xCoordinate + 1, yCoordinate].GetStatus))
            {
                return true;
            }
            else if (monsterStatusList.Contains(map.FullMap[xCoordinate - 1, yCoordinate].GetStatus))
            {
                return true;
            }
            else if (monsterStatusList.Contains(map.FullMap[xCoordinate, yCoordinate + 1].GetStatus))
            {
                return true;
            }
            else if (monsterStatusList.Contains(map.FullMap[xCoordinate, yCoordinate - 1].GetStatus))
            {
                return true;
            }

            return false;
            ;
        }

        public static bool IsBossNearby(Character player, Map map, Monster boss)
        {

            return false;
        }

        public static bool DirectionUpIsWallOrChangeLevel(string direction, Character character)
        {
            var moveUp = (character.Position.y, character.Position.x - 1);
            LevelManager.CheckKeyAndChangeLevel(direction, character);
            if (ItIsWall(direction, _walls)) return false;
            character.Position = moveUp;
            return true;
        }

        public static bool DirectionDownIsWallOrChangeLevel(string direction, Character character)
        {
            var moveDown = (character.Position.y, character.Position.x + 1);
            LevelManager.CheckKeyAndChangeLevel(direction, character);
            if (ItIsWall(direction, _walls)) return false;
            character.Position = moveDown;
            return true;
        }

        public static bool DirectionLeftIsWallOrChangeLevel(string direction, Character character)
        {
            var moveLeft = (character.Position.y - 1, character.Position.x);
            LevelManager.CheckKeyAndChangeLevel(direction, character);
            if (ItIsWall(direction, _walls)) return false;
            character.Position = moveLeft;
            return true;
        }

        public static bool DirectionRightIsWallOrChangeLevel(string direction, Character character)
        {
            var moveRight = (character.Position.y + 1, character.Position.x);
            LevelManager.CheckKeyAndChangeLevel(direction, character);
            if (ItIsWall(direction, _walls)) return false;
            character.Position = moveRight;
            return true;
        }
    }
}
