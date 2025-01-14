namespace Systekna.Agenda.One;

public class DbTarefa : DataFake, IDbTarefa
{
    public void Add(Tarefa tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void Remove(string titulo)
    {
        tarefas.RemoveAll(t => t.Titulo == titulo);
    }

    public IEnumerable<Tarefa> ToList()
    {
        return tarefas;
    }
}
