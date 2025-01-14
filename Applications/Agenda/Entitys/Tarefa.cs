namespace Systekna.Agenda.One;

public class Tarefa : AgendaBase
{
    public DateTime DataVencimento { get; set; }
    public string Prioridade { get; set; }  // Alta, Média, Baixa
    public bool Concluida { get; set; }

    public Tarefa(string titulo, string descricao, DateTime dataVencimento, string prioridade)
    {
        Titulo = titulo;
        Descricao = descricao;
        DataVencimento = dataVencimento;
        Prioridade = prioridade;
        Concluida = false;
    }

    public override string ToString()
        => $"{DataVencimento.ToShortDateString()} - {Titulo} ({Prioridade}): {Descricao} [{(Concluida ? "Concluída" : "Pendente")}]";
}
