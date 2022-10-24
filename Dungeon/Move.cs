using Dungeon.Enum;

namespace Dungeon
{
    internal class Move
    {
        internal void Player(Player player)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    Direction direction;
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            direction = Direction.Up;
                            Console.WriteLine("Movement up");
                            break;
                        case ConsoleKey.DownArrow:
                            direction = Direction.Down;
                            Console.WriteLine("Movement down");
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = Direction.Left;
                            Console.WriteLine("Movement left");
                            break;
                        case ConsoleKey.RightArrow:
                            direction = Direction.Right;
                            Console.WriteLine("Movement right");
                            break;
                        case ConsoleKey.E:
                            direction = Direction.Inventory;
                            Console.WriteLine("Open equipment");
                            break;
                        //default:
                        //    if (direction == Direction.Inventory)
                        //    {

                        //    }
                    }
                }
            }
        }
    }
}
