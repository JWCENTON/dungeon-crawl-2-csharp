using System.Configuration;
using Microsoft.Data.SqlClient;
namespace Dungeon.SqlManager;

public class dungeonDbManager
{
    public string ConnectionString => ConfigurationManager.AppSettings["connectionString"];
    public dungeonDbManager()
    {
        EnsureConnectionSuccessful();
    }


    private void EnsureConnectionSuccessful()
    {
        if (!TestConnection())
        {
            Console.WriteLine("Connection failed, exit!");
            Environment.Exit(1);
        }
        Console.WriteLine("Connection successful");
    }

    private bool TestConnection()
    {
        using var connection = new SqlConnection(ConnectionString);
        try
        {
            connection.Open();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}

