using Scrum.Core;

namespace Scrum.Repository.Interfaces;

public interface IDbSprint : IQueryTask<Sprint>
{
    void Add(Sprint sprint);
    void AddEpico(int idSprint, Epicos? epicos);
    void Remove(Sprint sprint);
}