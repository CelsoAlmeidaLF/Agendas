namespace Systekna.Agenda.One;

public class DbEvento : DataFake, IDbEvento
{
    public void Add(Evento evento)
    {
        eventos.Add(evento);
    }

    public void Remove(DateTime data)
    {
        eventos.RemoveAll(e => e.Data == data);
    }

    public IEnumerable<Evento> ToList()
    {
        return eventos;
    }
}