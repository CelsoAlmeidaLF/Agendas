using Systekna.Scrum.Core;

namespace Systekna.Scrum.Application;

public class BbSprint
{
    public List<Sprint> sprintList = new List<Sprint>();
    public int taskIdCounter = 1;
}

public class AppSprint
{
    private List<Sprint> _data;
    private List<Core.Task> tasks;

    public int taskIdCounter { get; private set; }

    public AppSprint() => _data = new List<Sprint>();

    public void AddSprint()
    {
        Console.WriteLine("Número do Sprint: ");
        int sprintNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Data de início do Sprint (dd/mm/yyyy): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Duração do Sprint em dias: ");
        int durationDays = int.Parse(Console.ReadLine());

        Sprint newSprint = new Sprint(sprintNumber, startDate, durationDays, tasks);
        _data.Add(newSprint);
        Console.WriteLine("Sprint adicionado com sucesso!");
    }

    public void AddTask()
    {
        if (_data.Count == 0)
        {
            Console.WriteLine("Nenhum Sprint disponível. Por favor, adicione um Sprint primeiro.");
            return;
        }

        Console.WriteLine("Número do Sprint: ");
        int sprintNumber = int.Parse(Console.ReadLine());
        Sprint sprint = _data.Find(s => s.SprintNumber == sprintNumber);

        if (sprint == null)
        {
            Console.WriteLine("Sprint não encontrado.");
            return;
        }

        Console.WriteLine("Título da tarefa: ");
        string title = Console.ReadLine();
        Console.WriteLine("Descrição da tarefa: ");
        string description = Console.ReadLine();
        Console.WriteLine("Data de início da tarefa (dd/mm/yyyy): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Duração da tarefa em dias: ");
        int durationDays = int.Parse(Console.ReadLine());

        Core.Task newTask = new Core.Task(taskIdCounter++, title, description, startDate, durationDays);
        sprint.Add(newTask);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    public void ListTasks()
    {
        foreach (var sprint in _data)
        {
            Console.WriteLine($"Sprint #{sprint.SprintNumber} - Início: {sprint.StartDate:dd/MM/yyyy}, Fim: {sprint.EndDate:dd/MM/yyyy}");
            sprint.GetAll();
            Console.WriteLine();
        }
    }

    public void RemoveTask()
    {
        Console.WriteLine("ID da tarefa a ser removida: ");
        int id = int.Parse(Console.ReadLine());

        foreach (var sprint in _data)
        {
            Core.Task task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                sprint.Remove(task);
                Console.WriteLine("Tarefa removida com sucesso!");
                return;
            }
        }

        Console.WriteLine("Tarefa não encontrada.");
    }

    public void ShowProgress()
    {
        int totalTasks = 0;
        int completedTasks = 0;

        foreach (var sprint in _data)
        {
            totalTasks += tasks.Count;
            completedTasks + tasks.FindAll(t => t.Status == "Done").Count;
        }

        if (totalTasks > 0)
        {
            double progress = (double)completedTasks / totalTasks * 100;
            Console.WriteLine($"Progresso: {completedTasks}/{totalTasks} ({progress:F2}%) tarefas concluídas.");
        }
        else
        {
            Console.WriteLine("Nenhuma tarefa registrada.");
        }
    }

    public void UpdateTask()
    {
        Console.WriteLine("ID da tarefa a ser atualizada: ");
        int id = int.Parse(Console.ReadLine());

        foreach (var sprint in _data)
        {
            Core.Task task = sprint.Tasks.Find(t => t.Id == id);
            if (task != null)
            {
                Console.WriteLine("Novo status da tarefa (ToDo/InProgress/Done): ");
                string status = Console.ReadLine();
                task.Status = status;
                Console.WriteLine("Tarefa atualizada com sucesso!");
                return;
            }
        }

        Console.WriteLine("Tarefa não encontrada.");
    }
}