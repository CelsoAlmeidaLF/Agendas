namespace Systekna.Agenda.One;

public interface IDbEvento : IRepository<Evento>
{
    void Remove(DateTime data);
}
