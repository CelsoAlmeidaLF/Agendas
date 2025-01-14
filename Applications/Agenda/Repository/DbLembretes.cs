using Systekna.Agenda.Repository.Data;
using Systekna.Agenda.One;

namespace Systekna.Agenda.Repository;

public class DbLembretes : DataFake, IDbLembretes
{
    public void Add(Lembrete lembrete)
    {
        lembretes.Add(lembrete);
    }

    public void Remove(DateTime data)
    {
        lembretes.RemoveAll(l => l.Data == data);
    }

    public IEnumerable<Lembrete> ToList()
    {
        return lembretes;
    }
}