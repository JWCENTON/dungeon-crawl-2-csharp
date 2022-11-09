using System.Configuration;
namespace Dungeon.SqlManager;

public class dungeonDbManager
{
    public string ConnectionString => ConfigurationManager.AppSettings["connectionString"];
    public dungeonDbManager()
    {
        EnsureConnectionSuccessful();
    }

    public bool TestConnection()
    {
        using var connection = new SqlManager
    }
}

