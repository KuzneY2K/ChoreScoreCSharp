using ChoreScore.Models;

namespace ChoreScore.Repositories;

public class ChoresRepository
{
    private List<Chore> _FakeDb;

    Guid id = Guid.NewGuid();

    public ChoresRepository()
    {
        _FakeDb = new List<Chore>();
        _FakeDb.Add(new Chore(id, "Clean", false, "Mark"));
        _FakeDb.Add(new Chore(id, "Do Dishes", false, "Mark"));
    }

    internal List<Chore> GetAllChores()
    {
        return _FakeDb;
    }

    internal Chore CreateChore(Chore choreData)
    {
        choreData.Id = id;
        _FakeDb.Add(choreData);
        return choreData;
    }
}