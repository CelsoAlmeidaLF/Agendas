namespace Systekna.Agenda.One;

public static class ClsAgenda
{
    public static void AdicionarEvento(Agenda agenda)
    {
        Console.Write("Digite a data do evento (dd/mm/yyyy hh:mm): ");
        DateTime data = DateTime.Parse(Console.ReadLine());
        Console.Write("Digite o título do evento: ");
        string titulo = Console.ReadLine();
        Console.Write("Digite a descrição do evento: ");
        string descricao = Console.ReadLine();
        Console.Write("Digite o local do evento: ");
        string local = Console.ReadLine();

        agenda.AdicionarEvento(new Evento(data, titulo, descricao, local));
    }

    public static void AdicionarTarefa(Agenda agenda)
    {
        Console.Write("Digite o título da tarefa: ");
        string titulo = Console.ReadLine();
        Console.Write("Digite a descrição da tarefa: ");
        string descricao = Console.ReadLine();
        Console.Write("Digite a data de vencimento da tarefa (dd/mm/yyyy): ");
        DateTime dataVencimento = DateTime.Parse(Console.ReadLine());
        Console.Write("Digite a prioridade da tarefa (Alta, Média, Baixa): ");
        string prioridade = Console.ReadLine();
        agenda.AdicionarTarefa(new Tarefa(titulo, descricao, dataVencimento, prioridade));
    }

    public static void AdicionarLembrete(Agenda agenda)
    {
        Console.Write("Digite a data do lembrete (dd/mm/yyyy hh:mm): ");
        DateTime data = DateTime.Parse(Console.ReadLine());
        Console.Write("Digite o título do lembrete: ");
        string titulo = Console.ReadLine();
        Console.Write("Digite a descrição do lembrete: ");
        string descricao = Console.ReadLine();
        agenda.AdicionarLembrete(new Lembrete(data, titulo, descricao));
    }

    public static void AdicionarNota(Agenda agenda)
    {
        Console.Write("Digite o título da nota: ");
        string titulo = Console.ReadLine();
        Console.Write("Digite o conteúdo da nota: ");
        string conteudo = Console.ReadLine();
        agenda.AdicionarNota(new Nota(titulo, conteudo));
    }

    public static void ExibirAgenda(Agenda agenda)
    {
        Console.Clear();
        agenda.ExibirEventos();
        agenda.ExibirTarefas();
        agenda.ExibirLembretes();
        agenda.ExibirNotas();
    }

    public static void RemoverItem(Agenda agenda)
    {
        Console.WriteLine("Escolha uma categoria para remover um item:");
        Console.WriteLine("1. Evento");
        Console.WriteLine("2. Tarefa");
        Console.WriteLine("3. Lembrete");
        Console.WriteLine("4. Nota");
        int categoria = int.Parse(Console.ReadLine());

        switch (categoria)
        {
            case 1:
                Console.Write("Digite a data do evento a ser removido (dd/mm/yyyy): ");
                DateTime dataEvento = DateTime.Parse(Console.ReadLine());
                agenda.RemoverEvento(dataEvento);
                break;
            case 2:
                Console.Write("Digite o título da tarefa a ser removida: ");
                string tituloTarefa = Console.ReadLine();
                agenda.RemoverTarefa(tituloTarefa);
                break;
            case 3:
                Console.Write("Digite a data do lembrete a ser removido (dd/mm/yyyy): ");
                DateTime dataLembrete = DateTime.Parse(Console.ReadLine());
                agenda.RemoverLembrete(dataLembrete);
                break;
            case 4:
                Console.Write("Digite o título da nota a ser removida: ");
                string tituloNota = Console.ReadLine();
                agenda.RemoverNota(tituloNota);
                break;
            default:
                Console.WriteLine("Categoria inválida!");
                break;
        }
    }

    public static void ExibirCalendarioCompleto(Agenda agenda)
    {
        Console.Clear();

        Console.Write("Digite o ano do calendário: ");
        int ano = int.Parse(Console.ReadLine());
        Console.Write("Digite o mês do calendário: ");
        int mes = int.Parse(Console.ReadLine());
        int diasNoMes = DateTime.DaysInMonth(ano, mes);

        Console.Clear();
        Console.WriteLine($"Calendário completo de {mes}/{ano}:");

        for (int dia = 1; dia <= diasNoMes; dia++)
        {
            DateTime dataAtual = new DateTime(ano, mes, dia);
            Console.WriteLine($"\n{dataAtual.ToShortDateString()}:");

            var eventosNoDia = agenda.ObterEventosNoDia(dataAtual);
            var tarefasNoDia = agenda.ObterTarefasNoDia(dataAtual);
            var lembretesNoDia = agenda.ObterLembretesNoDia(dataAtual);
            var notasNoDia = agenda.ObterNotasNoDia();

            if (eventosNoDia.Any() || tarefasNoDia.Any() || lembretesNoDia.Any() || notasNoDia.Any())
            {
                foreach (var evento in eventosNoDia)
                {
                    Console.WriteLine($"  Evento: {evento.Titulo} - {evento.Descricao}");
                }
                foreach (var tarefa in tarefasNoDia)
                {
                    Console.WriteLine($"  Tarefa: {tarefa.Titulo} - {tarefa.Descricao} (Prioridade: {tarefa.Prioridade})");
                }
                foreach (var lembrete in lembretesNoDia)
                {
                    Console.WriteLine($"  Lembrete: {lembrete.Titulo} - {lembrete.Descricao}");
                }
                foreach (var nota in notasNoDia)
                {
                    Console.WriteLine($"  Nota: {nota.Titulo} - {nota.Conteudo}");
                }
            }
            else
            {
                Console.WriteLine("  Sem eventos, tarefas, lembretes ou notas.");
            }
        }
    }

    public static int ExibirMenu()
    {
        Console.WriteLine();
        Console.WriteLine("================================================================");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("1. Adicionar evento");
        Console.WriteLine("2. Adicionar tarefa");
        Console.WriteLine("3. Adicionar lembrete");
        Console.WriteLine("4. Adicionar nota");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("6. Remover item");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("5. Exibir agenda");
        Console.WriteLine("7. Exibir calendário completo");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("8. Sair");
        Console.WriteLine("================================================================");
        Console.Write("_");
        return int.Parse(Console.ReadLine());
    }
}

public static class ConsoleAgenda
{
    public static void Build(Agenda agenda)
    {
        Console.Title = $"Agenda {DateTime.Now.Year} [DEV]";
        while (true)
        {
            int opcao = ClsAgenda.ExibirMenu();

            switch (opcao)
            {
                case 1:
                    ClsAgenda.AdicionarEvento(agenda);
                    break;
                case 2:
                    ClsAgenda.AdicionarTarefa(agenda);
                    break;
                case 3:
                    ClsAgenda.AdicionarLembrete(agenda);
                    break;
                case 4:
                    ClsAgenda.AdicionarNota(agenda);
                    break;
                case 5:
                    ClsAgenda.ExibirAgenda(agenda);
                    break;
                case 6:
                    ClsAgenda.RemoverItem(agenda);
                    break;
                case 7:
                    ClsAgenda.ExibirCalendarioCompleto(agenda);
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}