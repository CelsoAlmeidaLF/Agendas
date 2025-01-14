using Systekna.Agenda.Repository.Data;

namespace Systekna.Agenda.One;

public interface IDbLembretes : IRepository<Lembrete>
{
    void Remove(DateTime data);
}
