namespace Dungeon.Monsters;
public class MonsterDAO : IMonsterDAO
{

    void IMonsterDAO.Add(Monster monster)
    {
        var name = monster.Name;
        var health = monster.Health;
        var attackValue = monster.AtackValue;
        var type = monster.Type;
        var position = monster.Position;

        const string insertCommand = @"";
    }


}
