namespace Systekna.Agenda.One;

public interface IDbNotas : IRepository<Nota>
{
    void Remove(string titulo);
}
