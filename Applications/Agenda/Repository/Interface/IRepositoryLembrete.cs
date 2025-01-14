namespace Systekna.Agenda.One;

public interface IRepositoryLembrete
{
    void AdicionarLembrete(Lembrete lembrete);
    void RemoverLembrete(DateTime data);
    void ExibirLembretes();
    List<Lembrete> ObterLembretesNoDia(DateTime data);
}