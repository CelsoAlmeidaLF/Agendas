
using Core = Systekna.Scrum.Core;

namespace Scrum.Repository.Interfaces;

public interface IDbScrum
{
    void Add(Core.Task newTask);
    IEnumerable<Core.Task> GetAll();
    void Remove(Core.Task task);
    Core.Task? GetByID(int id);
    int GetByStatusDone();
    int Count { get; }
}
