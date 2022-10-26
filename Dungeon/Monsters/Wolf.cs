namespace Dungeon.Monsters
{
    public class Wolf : Monster

    {
        public (int x, int y) Position { get; set; }
        public string Name { get; }
        public int Health { get; set; }
        public int AtackValue { get; }
        public string TypeAtack { get; }
        public Item Item { get; set; }

        public Wolf((int, int) startedPosition)
        {
            this.Position = startedPosition;
            Name = "Wolf";
            Health = SetMonsterIntValue(21,29);
            AtackValue = SetMonsterIntValue(4, 8);
            TypeAtack = "Beat";
            this.Item = new Item("Claw");
        }
    }
}
