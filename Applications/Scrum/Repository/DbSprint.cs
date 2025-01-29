using Scrum.Core;
using Scrum.Repository;
using Scrum.Repository.Interfaces;

namespace Systekna.Scrum.Repository;

public class DbSprint : DbFake, IDbSprint
{
    #region ...

    public DbSprint() 
        => _sprints = new();

    public DbSprint(List<Sprint> sprints) 
        => _sprints = sprints;

    #endregion

    public int Count => _sprints.Count;

    public virtual void Add(Sprint sprint) 
        => _sprints.Add(sprint);

    public void AddEpico(int idSprint, Epicos? epicos) 
        => _sprints[idSprint].Epicos.Add(epicos ?? new Epicos(0, _sprints[0].Title, _sprints[0].Description, ItemStatus.ToDo));

    public virtual IEnumerable<Sprint> GetAll()
        => _sprints;

    public virtual Sprint? GetByID(int id)
        => _sprints.Find(t => t.ID == id);

    public int GetByStatusDone()
    {
        return 0;
    }

    public virtual void Remove(Sprint sprint) 
        => _sprints.Remove(sprint);
}