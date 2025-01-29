using Scrum.Core;

namespace Scrum.Repository.Interfaces;

public interface IDbScrum : IQueryTask<Epicos>
{
    void Add(Epicos epicos);
    void AddTask(int idEpico, ToDo toDo);
    void ClearTask(int idEpico);
    void Remove(Epicos epicos);
    void Update(int id, ItemStatus status);

}
