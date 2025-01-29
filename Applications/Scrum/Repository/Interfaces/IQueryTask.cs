using Scrum.Core;

namespace Scrum.Repository.Interfaces;

public interface IQueryTask<Entity>
{
    IEnumerable<Entity> GetAll();
    Entity? GetByID(int id);
    int GetByStatusDone();
    int Count { get; }
}