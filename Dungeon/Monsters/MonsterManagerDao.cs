using Dungeon.SqlManager;

namespace Dungeon.Monsters
{
    public class MonsterManagerDao
    {
        public void ManageMonstersDao(Monster boss)
        {
            var connection = new DungeonDbManager();
            var monsterDao = new MonsterDao(connection.ConnectionString);
            var monsterManager = new DungeonDbManagerDao();
            monsterManager.ClearMonstersTable(connection);
            monsterDao.Add(boss);
        }
    }
}
