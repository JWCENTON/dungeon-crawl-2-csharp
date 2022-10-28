using Dungeon.Enum;

namespace Dungeon.Monsters
{
    public class Wolf : Monster
    {
        private static int count = 1;
        public Wolf((int, int) startedPosition)
        {
            Name = "Wolf";
            ID = count++;
            Position = startedPosition;
            Health = SetMonsterIntValue(21,29);
            AtackValue = SetMonsterIntValue(4, 8);
            TypeAtack = "Beat";
            this.Item = new Item("Claw");
            IsAlive = true;
            Type = Status.Monster1;
            MapLevel = 1;
        }
    }
}
