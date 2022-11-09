namespace Dungeon.Monsters;

public interface IMonsterDao
{
    public void Add(Monster monster);
    public void Remove(Monster monster);
}

