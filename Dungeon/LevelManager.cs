using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class LevelManager
    {
        private static void RemoveKeyFromEquipment(Character character)
        {
            var key = "K";
            var keyIndex = character.Equipment.IndexOf(key);
            character.Equipment.RemoveAt(keyIndex);
        }
        public static void CheckKeyAndChangeLevel(string directionStatus, Character character)
        {
            var entrance = "#";
            if (character.Equipment.Contains("K") && directionStatus == entrance)
            {
                character.Level = character.Level == "Top floor" ? "Ground floor" : "Top floor";
                //RemoveKeyFromEquipment(character);
            }
        }
    }
}
