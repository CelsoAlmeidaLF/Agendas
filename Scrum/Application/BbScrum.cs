using Scrum.Repository.Interfaces;
using Systekna.Scrum.Repository;

namespace Systekna.Scrum.Code;

public class BbScrum
{
    #region ...
    private readonly IDbScrum _db;
    public BbScrum() => _db = new DbScrum();
    #endregion

    private int taskIdCounter = 1;

    #region 'insert'
    public void AddTask()
    {
        Console.WriteLine("Título da tarefa: ");
        string title = Console.ReadLine();
        Console.WriteLine("Descrição da tarefa: ");
        string description = Console.ReadLine();
        Console.WriteLine("Data de início da tarefa (dd/mm/yyyy): "); 
        DateTime startDate = DateTime.Parse(Console.ReadLine()); 
        Console.WriteLine("Duração da tarefa em dias: "); 
        int durationDays = int.Parse(Console.ReadLine());

        Core.Task newTask = new Core.Task(taskIdCounter++, title, description, startDate, durationDays);
        _db.Add(newTask);

        Console.WriteLine("Tarefa adicionada com sucesso!");
    }
    #endregion

    #region 'list'
    public void ListTasks()
    {
        foreach (var task in _db.GetAll())
        {
            Console.WriteLine($"ID: {task.Id}, Título: {task.Title}, Descrição: {task.Description}, Status: {task.Status}");
        }
    }
    #endregion

    #region 'remove'
    public void RemoveTask()
    {
        Console.WriteLine("ID da tarefa a ser removida: ");
        int id = int.Parse(Console.ReadLine());

        Core.Task? task = _db.GetByID(id);
        if (task != null)
        {
            _db.Remove(task);
            Console.WriteLine("Tarefa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }
    #endregion

    #region 'show progress'
    public void ShowProgress()
    {
        int totalTasks = _db.Count;
        int completedTasks = _db.GetByStatusDone();

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
    #endregion

    #region 'update'
    public void UpdateTask()
    {
        Console.WriteLine("ID da tarefa a ser atualizada: ");
        int id = int.Parse(Console.ReadLine());

        Core.Task? task = _db.GetByID(id);
        if (task != null)
        {
            Console.WriteLine("Novo status da tarefa (ToDo/InProgress/Done): ");
            string status = Console.ReadLine();
            task.Status = status;
            Console.WriteLine("Tarefa atualizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }
    #endregion
}
