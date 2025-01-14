namespace Systekna.Agenda.Repository.Data;

public interface IRepository<Entity>
{
    void Add(Entity tarefa);
    IEnumerable<Entity> ToList();
}
