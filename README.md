# Dungeon Crawl

## Story

Roguelikes are one of the oldest types of video games. The earliest ones were made in the 70s, and they were inspired a lot by tabletop RPGs. Roguelikes usually have the following features in common.

They are tile-based.
The game is divided into turns, that is, you take one action, then the other entities (monsters, allies, and so on, controlled by the CPU) take one.
The task is usually to explore a labyrinth and retrieve some treasure from its bottom.
They feature permadeath: if you die, it's game over, you need to start from the beginning again.
They rely heavily on procedural generation: Levels, monster placement, items, and so on are randomized, so the game does not get boring.

- game sharing between players
- maps of different sizes
- player-tracking camera movement


> Using database for saving game state feature is a business critical item which overrides every other priority now!

## What have been introduced?

- Serialize objects.
- Communicate with databases.
- Write unit tests.
- Understand the **Data Access Object** design pattern.

## General requirements

None

## Background materials

- <i class="far fa-exclamation"></i> [Software testing](project/curriculum/materials/pages/general/software-testing.md)
- <i class="far fa-book-open"></i> [Positive or negative](https://stackoverflow.com/questions/8162423)
- <i class="far fa-exclamation"></i> [How to design classes](project/curriculum/materials/pages/csharp/how-to-design-classes.md)
- <i class="far fa-book-open"></i> [Unity Documentaton](https://docs.unity3d.com/Manual/index.html)
- <i class="far fa-exclamation"></i> [SQL in Visual Studio and CRUD operations](https://alexcodetuts.com/2019/04/26/how-to-connect-sql-server-database-using-c-and-perform-crud-operation-part-1/)
- <i class="far fa-exclamation"></i> [Obtaining data through SQL DataReader](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-data-using-a-datareader)
- <i class="far fa-exclamation"></i> [JSON.NET](https://www.newtonsoft.com/json)
- [1-Bit Pack by Kenney](https://kenney.nl/assets/bit-pack)
