namespace Systekna.Agenda.One;

public interface IRepository<Entity>
{
    void Add(Entity tarefa);
    IEnumerable<Entity> ToList();
}
