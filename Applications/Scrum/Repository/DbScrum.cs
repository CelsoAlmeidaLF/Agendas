using Scrum.Repository.Interfaces;
using Systekna.Scrum.Core;

namespace Systekna.Scrum.Repository;

public class DbScrum : IDbScrum
{
    #region ...
    private List<Core.Task> _data;
    public int Count => _data.Count;
    public DbScrum(List<Core.Task> tasks) => _data = tasks;
    public DbScrum() => _data = new List<Core.Task>();
    #endregion

    public virtual void Add(Core.Task newTask) 
        => _data.Add(newTask);

    public virtual IEnumerable<Core.Task> GetAll() 
        => _data;

    public virtual void Update(int id, string status)
    {
        Core.Task? task = GetByID(id);
        if (task != null)
            task.Status = status;
    }

    public virtual Core.Task? GetByID(int id) 
        => _data.Find(t => t.Id == id);

    public virtual int GetByStatusDone() 
        => _data.FindAll(t => t.Status == "Done").Count;

    public virtual void Remove(Core.Task task) 
        => _data.Remove(task);

    public bool IsValidSprint(Sprint? sprint)
    {
        if (sprint is null) return false;
        _data = sprint.Tasks;
        return true;
    }
}
