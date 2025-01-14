using Systekna.Agenda.Repository.Data;

namespace Systekna.Agenda.One;

public interface IDbTarefa : IRepository<Tarefa>
{
    void Remove(string titulo);
}