using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;

namespace Dungeon.SqlManager
{
    public class DungeonDbManagerDao : IDungeonDbManagerDao
    {
        public void ClearMonstersTable(DungeonDbManager connectionManager)
        {
            const string clearCommand = @"TRUNCATE TABLE monsters";

            try
            {
                using var connection = new SqlConnection(connectionManager.ConnectionString);
                var cmd = new SqlCommand(clearCommand, connection);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException e)
            {
                throw new RuntimeWrappedException(e);
            }
        }
    }
}
