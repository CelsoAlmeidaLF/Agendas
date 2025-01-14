namespace Systekna.Agenda.One;

public interface IRepositoryNotas
{
    void AdicionarNota(Nota nota);
    void RemoverNota(string titulo);
    void ExibirNotas();
    List<Nota> ObterNotasNoDia();
}
