using Scrum.MPV1.Model;

namespace Scrum.MPV1.Service;

class Program
{
    static void Main(string[] args)
    {
        var backlog = new ProductBacklog();
        bool exit = false;
        while (!exit)
        {
            ExibirMenuPrincipal();
            var option = Console.ReadLine();
            exit = ProcessarOpcao(backlog, option);
        }
    }
   
    static void ExibirMenuPrincipal()
    {
        ExibirMenu("Gestão de Cronograma Scrum:",
            new Dictionary<string, string> {
                { "1", "Gerenciar Itens" },
                { "2", "Gerenciar Sprints" },
                { "3", "Outros" },
                { "4", "Sair" }
            });
    }
    
    static void ExibirMenu(string titulo, Dictionary<string, string> opcoes)
    {
        Console.Clear(); Console.WriteLine(new string('*', 30));
        Console.WriteLine($"*{titulo.PadLeft((titulo.Length + 28) / 2).PadRight(28)}*");
        Console.WriteLine(new string('*', 30)); foreach (var opcao in opcoes)
        {
            Console.WriteLine($"* {opcao.Key}. {opcao.Value.PadRight(24)}*");
        }
        Console.WriteLine(new string('*', 30)); Console.Write("Selecione uma opção: ");
    }
    
    static bool ProcessarOpcao(ProductBacklog backlog, string option)
    {
        var menus = new Dictionary<string, Action>
        {
            { "1", ExibirMenuGerenciarItens },
            { "2", ExibirMenuGerenciarSprints },
            { "3", ExibirMenuOutros } };
        if (option == "4")
            return true;

        if (menus.ContainsKey(option))
        {
            menus[option].Invoke();
        }
        else
        {
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
        }
        Console.WriteLine(); Console.WriteLine("Pressione qualquer tecla para continuar..."); Console.ReadKey(); return false;
    }
    
    static void ExibirMenuGerenciarItens()
    {
        ExibirMenu("Gerenciar Itens:",
            new Dictionary<string, string> {
                { "1.1", "Adicionar Item" },
                { "1.2", "Atualizar Item" },
                { "1.3", "Remover Item" },
                { "1.4", "Visualizar Backlog" }
            });
    }
    
    static void ExibirMenuGerenciarSprints()
    {
        ExibirMenu("Gerenciar Sprints:",
            new Dictionary<string, string> {
                { "2.1", "Adicionar Sprint" },
                { "2.2", "Atualizar Sprint" },
                { "2.3", "Remover Sprint" },
                { "2.4", "Visualizar Sprints" }
            });
    }
    
    static void ExibirMenuOutros()
    {
        ExibirMenu("Outros:",
            new Dictionary<string, string> {
                { "3.1", "Adicionar Item ao Backlog da Sprint" },
                { "3.2", "Visualizar Backlog da Sprint" },
                { "3.3", "Visualizar Cronograma" }
            });
    }
}

static class UIHelper
{
    public static void AdicionarItem(ProductBacklog backlog)
    {
        Console.Write("Digite o título: ");
        var title = Console.ReadLine();
        Console.Write("Digite a descrição: ");
        var description = Console.ReadLine();
        Console.WriteLine("Digite o status (ToDo, InProgress, Done): ");
        if (!Enum.TryParse(Console.ReadLine(), out ItemStatus status))
        {
            Console.WriteLine("Status inválido.");
            return;
        }
        backlog.AddItem(title, description, status);
        Console.WriteLine("Item adicionado com sucesso!");
    }

    public static void AtualizarItem(ProductBacklog backlog)
    {
        Console.Write("Digite o ID do item a ser atualizado: ");
        if (!int.TryParse(Console.ReadLine(), out int updateId))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        Console.Write("Digite o novo título: ");
        var newTitle = Console.ReadLine();
        Console.Write("Digite a nova descrição: ");
        var newDescription = Console.ReadLine();
        Console.WriteLine("Digite o novo status (ToDo, InProgress, Done): ");
        if (!Enum.TryParse(Console.ReadLine(), out ItemStatus newStatus))
        {
            Console.WriteLine("Status inválido.");
            return;
        }
        backlog.UpdateItem(updateId, newTitle, newDescription, newStatus);
        Console.WriteLine("Item atualizado com sucesso!");
    }

    public static void RemoverItem(ProductBacklog backlog)
    {
        Console.Write("Digite o ID do item a ser removido: ");
        if (!int.TryParse(Console.ReadLine(), out int removeId))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        backlog.RemoveItem(removeId);
        Console.WriteLine("Item removido com sucesso!");
    }

    public static void AdicionarSprint(ProductBacklog backlog)
    {
        Console.Write("Digite o nome da sprint: ");
        var sprintName = Console.ReadLine();
        Console.Write("Digite a data de início (yyyy-MM-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
        {
            Console.WriteLine("Data de início inválida.");
            return;
        }
        Console.Write("Digite a data de término (yyyy-MM-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
        {
            Console.WriteLine("Data de término inválida.");
            return;
        }
        backlog.AddSprint(sprintName, startDate, endDate);
        Console.WriteLine("Sprint adicionada com sucesso!");
    }

    public static void AtualizarSprint(ProductBacklog backlog)
    {
        Console.Write("Digite o ID da sprint a ser atualizada: ");
        if (!int.TryParse(Console.ReadLine(), out int updateSprintId))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        Console.Write("Digite o novo nome da sprint: ");
        var newSprintName = Console.ReadLine();
        Console.Write("Digite a nova data de início (yyyy-MM-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime newStartDate))
        {
            Console.WriteLine("Data de início inválida.");
            return;
        }
        Console.Write("Digite a nova data de término (yyyy-MM-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime newEndDate))
        {
            Console.WriteLine("Data de término inválida.");
            return;
        }
        backlog.UpdateSprint(updateSprintId, newSprintName, newStartDate, newEndDate);
        Console.WriteLine("Sprint atualizada com sucesso!");
    }

    public static void RemoverSprint(ProductBacklog backlog)
    {
        Console.Write("Digite o ID da sprint a ser removida: ");
        if (!int.TryParse(Console.ReadLine(), out int removeSprintId))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        backlog.RemoveSprint(removeSprintId);
        Console.WriteLine("Sprint removida com sucesso!");
    }

    public static void AdicionarItemAoBacklogDaSprint(ProductBacklog backlog)
    {
        Console.Write("Digite o ID da sprint: ");
        if (!int.TryParse(Console.ReadLine(), out int sprintId))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        Console.Write("Digite o ID do item a ser adicionado: ");
        if (!int.TryParse(Console.ReadLine(), out int sprintItemId))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        backlog.AddItemToSprintBacklog(sprintId, sprintItemId);
        Console.WriteLine("Item adicionado ao backlog da sprint com sucesso!");
    }

    public static void VisualizarBacklogDaSprint(ProductBacklog backlog)
    {
        Console.Write("Digite o ID da sprint para visualizar o backlog: ");
        if (!int.TryParse(Console.ReadLine(), out int viewSprintId))
        {
            Console.WriteLine("ID inválido.");
            return;
        }
        backlog.ViewSprintBacklog(viewSprintId);
    }
}
