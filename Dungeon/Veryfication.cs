using System.Threading.Channels;

namespace Dungeon
{
    public class Verification
    {
        public bool DirectionUpIsWall(Map map, Character character)
        {
            if (map.FullMap[character.Position.x - 1, character.Position.y].GetStatus != "=")
            {
                character.Position = (character.Position.y, character.Position.x - 1);
                return true;
            }
            return false;
        }
        public bool DirectionDownIsWall(Map map, Character character)
        {
            if (map.FullMap[character.Position.x + 1, character.Position.y].GetStatus != "=")
            {
                character.Position = (character.Position.y, character.Position.x + 1);
                return true;
            }
            return false;
        }

        public bool DirectionLeftIsWall(Map map, Character character)
        {
            if (map.FullMap[character.Position.x, character.Position.y - 1].GetStatus != "||")
            {
                character.Position = (character.Position.y - 1, character.Position.x);
                return true;
            }
            return false;
        }
        public bool DirectionRightIsWall(Map map, Character character)
        {
            if (map.FullMap[character.Position.x, character.Position.y + 1].GetStatus != "||")
            {
                character.Position = (character.Position.y + 1, character.Position.x);
                return true;
            }
            return false;
        }
    }
}
