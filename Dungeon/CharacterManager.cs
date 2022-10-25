using Dungeon.Enum;

namespace Dungeon
{
    public class CharacterManager
    {
        internal void MakeMove(Character character)
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
                        default:
                            direction = Direction.DontMove;
                            break;
                    }

                    if (direction != Direction.DontMove && direction != Direction.Inventory)
                    {
                        ChangePosition(character, direction);
                    }
                    else if (direction == Direction.Inventory)
                    {

                    }
                }
            }
        }

        public void ChangePosition(Character character, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    character.position = (character.position.y - 1, character.position.x);
                    break;
                case Direction.Down:
                    character.position = (character.position.y + 1, character.position.x);
                    break;
                case Direction.Left:
                    character.position = (character.position.y, character.position.x - 1);
                    break;
                case Direction.Right:
                    character.position = (character.position.y, character.position.x + 1);
                    break;
            }
        }
    }
}
