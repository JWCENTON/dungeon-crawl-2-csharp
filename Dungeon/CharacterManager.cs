using Dungeon.Enum;

namespace Dungeon
{
    public class CharacterManager
    {
        internal void MakeMove(Player character)
        {
            bool endOfMovement = false;
            while (!endOfMovement)
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
                        default:
                            direction = Direction.DontMove;
                            break;
                    }

                    if (direction != Direction.DontMove && direction != Direction.Inventory)
                    {
                        ChangePosition(character, direction);
                        endOfMovement = true;
                        direction = Direction.DontMove;
                    }
                    else if (direction == Direction.Inventory)
                    {
                        endOfMovement = true;
                        direction = Direction.DontMove;
                    }
                }
            }
        }

        public void ChangePosition(Player character, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    character.Position = (character.Position.y - 1, character.Position.x);
                    break;
                case Direction.Down:
                    character.Position = (character.Position.y + 1, character.Position.x);
                    break;
                case Direction.Left:
                    character.Position = (character.Position.y, character.Position.x - 1);
                    break;
                case Direction.Right:
                    character.Position = (character.Position.y, character.Position.x + 1);
                    break;
            }
        }
    }
}
