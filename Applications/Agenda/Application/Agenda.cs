using Systekna.Agenda.Repository;
using Systekna.Agenda.Repository.Interface;

namespace Systekna.Agenda.One;

public class Agenda : IDbAgenda
{
    #region ...

    private static Agenda _agenda = null!;

    private readonly IDbEvento dbEvento;
    private readonly IDbTarefa dbTarefa;
    private readonly IDbLembretes dbLembretes;
    private readonly IDbNotas dbNotas;

    public Agenda()
    {
        dbEvento = new DbEvento();
        dbTarefa = new DbTarefa();
        dbLembretes = new DbLembretes();
        dbNotas = new DbNotas();
    }

    public static Agenda Create()
    {
        _agenda = new();
        return _agenda;
    }
    #endregion

    #region 'insert'
    public void AdicionarEvento(Evento evento)
    {
        dbEvento.Add(evento);
        Console.WriteLine("Evento adicionado com sucesso!");
    }
    public void AdicionarTarefa(Tarefa tarefa)
    {
        dbTarefa.Add(tarefa);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }
    public void AdicionarLembrete(Lembrete lembrete)
    {
        dbLembretes.Add(lembrete);
        Console.WriteLine("Lembrete adicionado com sucesso!");
    }
    public void AdicionarNota(Nota nota)
    {
        dbNotas.Add(nota);
        Console.WriteLine("Nota adicionada com sucesso!");
    }
    #endregion

    #region 'delete'
    public void RemoverEvento(DateTime data)
    {
        dbEvento.Remove(data);
        Console.WriteLine("Evento removido com sucesso!");
    }

    public void RemoverTarefa(string titulo)
    {
        dbTarefa.Remove(titulo);
        Console.WriteLine("Tarefa removida com sucesso!");
    }

    public void RemoverLembrete(DateTime data)
    {
        dbLembretes.Remove(data);
        Console.WriteLine("Lembrete removido com sucesso!");
    }

    public void RemoverNota(string titulo)
    {
        dbNotas.Remove(titulo);
        Console.WriteLine("Nota removida com sucesso!");
    }
    #endregion

    #region 'consulta'
    public void ExibirEventos()
    {
        Console.WriteLine("Eventos:");
        foreach (var evento in dbEvento.ToList())
        {
            Console.WriteLine(evento.ToString());
        }
    }

    public void ExibirTarefas()
    {
        Console.WriteLine("Tarefas:");
        foreach (var tarefa in dbTarefa.ToList())
        {
            Console.WriteLine(tarefa.ToString());
        }
    }

    public void ExibirLembretes()
    {
        Console.WriteLine("Lembretes:");
        foreach (var lembrete in dbLembretes.ToList())
        {
            Console.WriteLine(lembrete.ToString());
        }
    }

    public void ExibirNotas()
    {
        Console.WriteLine("Notas:");
        foreach (var nota in dbNotas.ToList())
        {
            Console.WriteLine(nota.ToString());
        }
    }
    #endregion

    #region 'list'
    public List<Evento> ObterEventosNoDia(DateTime data)
    {
        return dbEvento.ToList().Where(e => e.Data.Date == data.Date).ToList();
    }

    public List<Tarefa> ObterTarefasNoDia(DateTime data)
    {
        return dbTarefa.ToList().Where(t => t.DataVencimento.Date == data.Date).ToList();
    }

    public List<Lembrete> ObterLembretesNoDia(DateTime data)
    {
        return dbLembretes.ToList().Where(l => l.Data.Date == data.Date).ToList();
    }

    public List<Nota> ObterNotasNoDia()
    {
        return (List<Nota>)dbNotas.ToList();
    }
    #endregion
}
