using Dungeon.SqlManager;

namespace Dungeon.Monsters
{
    public class MonsterManagerDao
    {
        public void ManageMonstersDao(List<Monster> monsters)
        {
            var connection = new DungeonDbManager();
            var monsterDao = new MonsterDao(connection.ConnectionString);
            var monsterManager = new DungeonDbManagerDao();
            monsterManager.ClearMonstersTable(connection);
            foreach (var monster in monsters)
            {
                monsterDao.Add(monster);
            }
        }
    }
}
