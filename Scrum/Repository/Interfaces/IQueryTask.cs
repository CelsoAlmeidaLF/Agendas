using Core = Systekna.Scrum.Core;

namespace Scrum.Repository.Interfaces;

public interface IQueryTask
{
    IEnumerable<Core.Task> GetAll();
    Core.Task? GetByID(int id);
    int GetByStatusDone();
    int Count { get; }
}