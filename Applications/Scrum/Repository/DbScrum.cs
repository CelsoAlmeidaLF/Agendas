using Scrum.Core;
using Scrum.Repository;
using Scrum.Repository.Interfaces;
using System.Threading.Tasks;

namespace Systekna.Scrum.Repository;

public class DbScrum : DbFake, IDbScrum
{
    #region ...
    public DbScrum(List<Epicos> tasks) => _epicos = tasks;
    public DbScrum() => _epicos = new List<Epicos>();
    #endregion
    
    public int Count => _epicos.Count;

    public virtual void Add(Epicos newTask) 
        => _epicos.Add(newTask);

    public virtual void AddTask(int idEpico, ToDo task) 
        => _epicos[idEpico].Tasks.Add(task);

    public virtual IEnumerable<Epicos> GetAll() 
        => _epicos;

    public virtual void Update(int id, ItemStatus status)
    {
        Epicos? task = GetByID(id);
        if (task != null)
            task.Status = status;
    }

    public virtual Epicos? GetByID(int id) 
        => _epicos.Find(t => t.ID == id);

    public virtual int GetByStatusDone() 
        => _epicos.FindAll(t => t.Status == ItemStatus.Done).Count;

    public virtual void Remove(Epicos task) 
        => _epicos.Remove(task);
    public void ClearTask(int idEpico)
        => _epicos[idEpico].Tasks.Clear();
}
