using Dungeon.Enum;
using Dungeon.Maps;

namespace Dungeon
{
    public class CharacterManager
    {
        internal void GetPlayerMove(Character character, Map map)
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
                        ChangePosition(character, direction, map);
                        endOfMovement = true;
                    }
                    else if (direction == Direction.Inventory)
                    {
                        endOfMovement = true;
                    }
                }
            }
        }

        public void ChangePosition(Character character, Direction direction, Map map)
        {
            Verification verify = new Verification();
            switch (direction)
            {
                case Direction.Up:
                    if (verify.DirectionUpIsWall(map, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
                case Direction.Down:
                    if (verify.DirectionDownIsWall(map, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
                case Direction.Left:
                    if (verify.DirectionLeftIsWall(map, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
                case Direction.Right:
                    if (verify.DirectionRightIsWall(map, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
            }
        }
    }
}
