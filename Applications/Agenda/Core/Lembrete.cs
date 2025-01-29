namespace Systekna.Agenda.One;

public class Lembrete : AgendaBase
{
    public DateTime Data { get; set; } = DateTime.Now;

    public Lembrete(DateTime data, string titulo, string descricao)
    {
        Data = data;
        Titulo = titulo;
        Descricao = descricao;
    }

    public override string ToString()
        => $"{Data.ToShortDateString()} {Data.ToShortTimeString()} - {Titulo}: {Descricao}";
}
