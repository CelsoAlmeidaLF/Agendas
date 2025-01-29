namespace Systekna.Agenda.One;

public class Nota : AgendaBase
{
    public string Conteudo { get; set; }

    public Nota(string titulo, string conteudo)
    {
        Titulo = titulo;
        Conteudo = conteudo;
    }

    public override string ToString()
        => $"{Titulo}: {Conteudo}";
}
