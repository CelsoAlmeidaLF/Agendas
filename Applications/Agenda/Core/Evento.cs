namespace Systekna.Agenda.One;

public class Evento : AgendaBase
{
    public DateTime Data { get; set; } = DateTime.Now;

    public Evento(DateTime data, string titulo, string descricao, string local)
    {
        Data = data;
        Titulo = titulo;
        Descricao = descricao;
        Local.Add("Não Salvo", local);
    }

    public override string ToString()
        => $"{Data.ToShortDateString()} {Data.ToShortTimeString()} - {Titulo} ({Local}): {Descricao}";
}