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
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Console.WriteLine("Movement up");
                            break;
                        case ConsoleKey.DownArrow:
                            Console.WriteLine("Movement down");
                            break;
                        case ConsoleKey.LeftArrow:
                            Console.WriteLine("Movement left");
                            break;
                        case ConsoleKey.RightArrow:
                            Console.WriteLine("Movement right");
                            break;
                        case ConsoleKey.E:
                            Console.WriteLine("Open equipment");
                            break;
                    }
                }
            }
        }
    }
}
