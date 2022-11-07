using Dungeon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Monsters
{
    public class Boss : Monster
    {
        public override int MapLevel { get; }
        public Boss((int, int) startedPosition)
        {
            Name = "BOSS";
            //ID = count++;
            Position = startedPosition;
            Health = 150;
            AtackValue = SetMonsterIntValue(10, 15);
            TypeAtack = "Beat";
            this.Item = new Item("Claw");
            IsAlive = true;
            Type = Status.Boss;
            MapLevel = 2;
        }
    }
}
