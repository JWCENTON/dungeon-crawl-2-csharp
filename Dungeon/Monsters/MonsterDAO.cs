﻿using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;

namespace Dungeon.Monsters;
public class MonsterDao : IMonsterDao
{
    private readonly string _connectionString;
    public MonsterDao(string connectionString)
    {
        _connectionString = connectionString;
    }
    public void Add(Monster monster)
    {
        const string insertCommand = @"INSERT INTO monsters (name, health, attack, monster_type, positionX, positionY, is_alive)
                                                        VALUES (@name, @health, @attack, @monster_type, @positionX, @positionY, @is_alive)
                                                        SELECT SCOPE_IDENTITY();";
        try
        {
            using var connection = new SqlConnection(_connectionString);
            var cmd = new SqlCommand(insertCommand, connection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            cmd.Parameters.AddWithValue("@name", monster.Name);
            cmd.Parameters.AddWithValue("@health", monster.Health);
            cmd.Parameters.AddWithValue("@attack", monster.AtackValue);
            cmd.Parameters.AddWithValue("@monster_type", monster.Type);
            cmd.Parameters.AddWithValue("@positionX", monster.Position.x);
            cmd.Parameters.AddWithValue("@positionY", monster.Position.y);
            cmd.Parameters.AddWithValue("@is_alive", monster.IsAlive);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        catch (SqlException e)
        {
            throw new RuntimeWrappedException(e);
        }
    }

    void IMonsterDao.Remove(Monster monster)
    {
        throw new NotImplementedException();
    }
}
