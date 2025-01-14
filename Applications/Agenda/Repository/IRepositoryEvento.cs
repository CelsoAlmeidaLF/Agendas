namespace Systekna.Agenda.One;

public interface IRepositoryEvento
{
    void AdicionarEvento(Evento evento);
    void RemoverEvento(DateTime data);
    void ExibirEventos();
    List<Evento> ObterEventosNoDia(DateTime data);
}