using Scrum.Repository.Interfaces;

namespace Systekna.Scrum.Repository;

public class DbScrum : IDbScrum
{
    private List<Core.Task> _data;
    public int Count => _data.Count;

    #region ...
    public DbScrum(List<Core.Task> tasks) => _data = tasks;
    public DbScrum() => _data = new List<Core.Task>();
    #endregion

    public virtual void Add(Core.Task newTask)
    {
        _data.Add(newTask);
    }

    public virtual IEnumerable<Core.Task> GetAll()
    {
        return _data;
    }

    public virtual Core.Task? GetByID(int id)
    {
        return _data.Find(t => t.Id == id);
    }

    public virtual int GetByStatusDone()
    { 
        return _data.FindAll(t => t.Status == "Done").Count;
    }

    public virtual void Remove(Core.Task task)
    {
        _data.Remove(task);
    }
}
