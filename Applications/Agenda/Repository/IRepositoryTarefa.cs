namespace Systekna.Agenda.One;

public interface IRepositoryTarefa
{
    void AdicionarTarefa(Tarefa tarefa);
    void RemoverTarefa(string titulo);
    void ExibirTarefas();
    List<Tarefa> ObterTarefasNoDia(DateTime data);
}