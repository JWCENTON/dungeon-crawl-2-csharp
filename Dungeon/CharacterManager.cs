using Dungeon.Enum;
using Dungeon.Maps;
using Dungeon.Monsters;

namespace Dungeon
{
    public class CharacterManager
    {
        public List<Monster> Monsters = new();

        private readonly List<((int xMin, int yMin), (int xMax, int yMax))> _allowedMonsterPositions = new List<((int, int), (int, int))>
        {
            ((44,23), (49,45)), ((30,23), (33,48))
        };

        private (int, int) GetMonsterPosition()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _allowedMonsterPositions.Count);
            var area = _allowedMonsterPositions[randomIndex];

            int xCoordinate = random.Next(area.Item1.Item1, area.Item2.Item1);
            int yCoordinate = random.Next(area.Item1.Item2, area.Item2.Item2);
            
            return (yCoordinate, xCoordinate);
        }

        internal void GetPlayerMove(Character player, Map map)
        {
            Verification verify = new Verification();
            Fight.Fight fight = new Fight.Fight();
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
                        ChangePosition(player, direction, map);
                        if (verify.IsMonsterNearby(player, map))
                        {
                            Monster monster = verify.WhatMonsterIsNearby(map, player.Position);
                            fight.FightWithMonster(player, monster);
                            Console.WriteLine("NICE");
                        }
                        endOfMovement = true;
                    }
                    else if (direction == Direction.Inventory)
                    {
                        if (player.ShowEquipment == false)
                        {
                            player.ShowEquipment = true;
                        }
                        else
                        {
                            player.ShowEquipment = false;
                        }
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
                    return new Wolf(GetMonsterPosition());
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
            var upDirectionStatus = map.FullMap[character.Position.x - 1, character.Position.y].GetStatus;
            var downDirectionStatus = map.FullMap[character.Position.x + 1, character.Position.y].GetStatus;
            var leftDirectionStatus = map.FullMap[character.Position.x, character.Position.y - 1].GetStatus;
            var rightDirectionStatus = map.FullMap[character.Position.x, character.Position.y + 1].GetStatus;
            switch (direction)
            {
                case Direction.Up:
                    Equipment.CollectItems(character, upDirectionStatus, map);
                    if (verify.DirectionUpIsWallOrChangeLevel(upDirectionStatus, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
                case Direction.Down:
                    Equipment.CollectItems(character, downDirectionStatus, map);
                    if (verify.DirectionDownIsWallOrChangeLevel(downDirectionStatus, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
                case Direction.Left:
                    Equipment.CollectItems(character, leftDirectionStatus, map);
                    if (verify.DirectionLeftIsWallOrChangeLevel(leftDirectionStatus, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
                case Direction.Right:
                    Equipment.CollectItems(character, rightDirectionStatus, map);
                    if (verify.DirectionRightIsWallOrChangeLevel(rightDirectionStatus, character))
                    {
                        break;
                    }
                    character.Position = (character.Position.y, character.Position.x);
                    break;
            }
        }
    }
}
