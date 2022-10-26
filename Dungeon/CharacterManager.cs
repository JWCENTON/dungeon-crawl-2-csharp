﻿using Dungeon.Enum;
using Dungeon.Maps;
using Dungeon.Monsters;

namespace Dungeon
{
    public class CharacterManager
    {
        public List<Monster> Monsters = new();
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
                            break;
                        case ConsoleKey.DownArrow:
                            direction = Direction.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            direction = Direction.Right;
                            break;
                        case ConsoleKey.E:
                            direction = Direction.Inventory;
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

        public void AddToListMonsters(Monster monster)
        {
            Monsters.Add(monster);
        }

        public Monster CreateMonster(Status typeOfMonster)
        {
            Monster monster = null;
            switch (typeOfMonster)
            {
                case Status.Monster1:
                    return new Wolf((29,32));
            }
            // TODO: throw error (not exist monster)

            return monster;
        }

        public List<Monster> CreateListOfMonsters(int quantity)
        {
            List<Monster> monsters = new List<Monster>();
            List<Status> monsterStatusList = new List<Status> {Status.Monster1}; //TODO: Add more monsters type
            Random r = new Random();

            for (int i = 0; i < quantity; i++)
            {
                int randomIndex = r.Next(monsterStatusList.Count);
                Status monsterType = monsterStatusList[randomIndex];
                // try catch (console write error) 
                monsters.Add(CreateMonster(monsterType));
            }

            return monsters;
        }

        public void ChangePosition(Character character, Direction direction, Map map)
        {
            Verification verify = new Verification();
            switch (direction)
            {
                case Direction.Up:
                    if (verify.DirectionUpIsWallOrChangeLevel(map, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
                case Direction.Down:
                    if (verify.DirectionDownIsWallOrChangeLevel(map, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
                case Direction.Left:
                    if (verify.DirectionLeftIsWallOrChangeLevel(map, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
                case Direction.Right:
                    if (verify.DirectionRightIsWallOrChangeLevel(map, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
            }
        }
    }
}
