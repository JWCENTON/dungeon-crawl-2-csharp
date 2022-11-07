using Dungeon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Monsters
{
    public class Bear : Monster
    {
        private static int _count = 1;
        public override int MapLevel { get; }
        public Bear ((int, int) startedPosition)
        {
            Name = "Bear";
            ID = _count++;
            Position = startedPosition;
            Health = SetMonsterIntValue(21, 29);
            AtackValue = SetMonsterIntValue(6, 10);
            TypeAtack = "Beat";
            this.Item = new Item("Claw");
            IsAlive = true;
            Type = Status.Monster2;
            MapLevel = 2;
        }
    }
}
