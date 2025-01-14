using Core = Systekna.Scrum.Core;

namespace Scrum.Repository.Interfaces;

public interface IDbScrum : IQueryTask
{
    void Add(Core.Task newTask);
    void Remove(Core.Task task);
}
