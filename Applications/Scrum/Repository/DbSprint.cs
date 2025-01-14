using Scrum.Repository.Interfaces;
using Systekna.Scrum.Core;

namespace Systekna.Scrum.Repository;

public class DbSprint : DbScrum, IDbSprint
{
    private readonly List<Sprint> _sprints;

    public DbSprint() 
        => _sprints = new List<Sprint>();

    public DbSprint(List<Sprint> sprints) 
        => _sprints = sprints;

    public virtual void AddSprint(Sprint sprint)
        => _sprints.Add(sprint);

    public virtual void AddTask(int idSprint, Core.Task task)
    {
        var sprint = _sprints.Find(s => s.SprintNumber == idSprint);
        if (IsValidSprint(sprint))
            base.Add(task);

    }

    public virtual void UpdateTask(int idSprint, int idTask, string status)
    {
        var sprint = _sprints.Find(s => s.SprintNumber == idSprint);
        if (IsValidSprint(sprint))
            base.Update(idTask, status);

    }

    public virtual void DelTask(int idSprint, Core.Task task)
    {
        var sprint = _sprints.Find(s => s.SprintNumber == idSprint);
        if (IsValidSprint(sprint))
           base.Remove(task);

    }
}