﻿using Dungeon.Enum;
using Dungeon.Maps;

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

        public bool IsMonsterNearby(Character player, Map map)
        {
            int xCoordinate = player.Position.x;
            int yCoordinate = player.Position.y;
            List<string> monsterStatusList = new List<string> { "1", "2", "3" };

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

        public static bool DirectionUpIsWallOrChangeLevel(string direction, Character character)
        {
            var upDirectionStatus = direction; //map.FullMap[character.Position.x - 1, character.Position.y].GetStatus;
            var moveUp = (character.Position.y, character.Position.x - 1);
            LevelManager.CheckKeyAndChangeLevel(upDirectionStatus, character);
            if (ItIsWall(upDirectionStatus, _walls)) return false;
            character.Position = moveUp;
            return true;
        }

        public static bool DirectionDownIsWallOrChangeLevel(string direction, Character character)
        {
            var downDirectionStatus = direction; //map.FullMap[character.Position.x + 1, character.Position.y].GetStatus;
            var moveDown = (character.Position.y, character.Position.x + 1);
            LevelManager.CheckKeyAndChangeLevel(downDirectionStatus, character);
            if (ItIsWall(downDirectionStatus, _walls)) return false;
            character.Position = moveDown;
            return true;
        }

        public static bool DirectionLeftIsWallOrChangeLevel(string direction, Character character)
        {
            var leftDirectionStatus = direction; //map.FullMap[character.Position.x, character.Position.y - 1].GetStatus;
            var moveLeft = (character.Position.y - 1, character.Position.x);
            LevelManager.CheckKeyAndChangeLevel(leftDirectionStatus, character);
            if (ItIsWall(leftDirectionStatus, _walls)) return false;
            character.Position = moveLeft;
            return true;
        }

        public static bool DirectionRightIsWallOrChangeLevel(string direction, Character character)
        {
            var rightDirectionStatus = direction; //map.FullMap[character.Position.x, character.Position.y + 1].GetStatus;
            var moveRight = (character.Position.y + 1, character.Position.x);
            LevelManager.CheckKeyAndChangeLevel(rightDirectionStatus, character);
            if (ItIsWall(rightDirectionStatus, _walls)) return false;
            character.Position = moveRight;
            return true;
        }
    }
}
