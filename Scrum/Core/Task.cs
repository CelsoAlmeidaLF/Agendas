using Systekna.Scrum.Repository;

namespace Systekna.Scrum.Core;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }  // "ToDo", "InProgress", "Done"
    public DateTime StartDate { get; set; }
    public int DurationDays { get; set; }  // Duração em dias

    public Task(int id, string title, string description, DateTime startDate, int durationDays)
    {
        Id = id;
        Title = title;
        Description = description;
        Status = "ToDo";
        StartDate = startDate;
        DurationDays = durationDays;
    }

    public DateTime GetEndDate()
    {
        return StartDate.AddDays(DurationDays);
    }
}

public class Sprint : DbScrum
{
    public int SprintNumber { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Sprint(int sprintNumber, DateTime startDate, int durationDays, List<Task> tasks)
        : base(tasks)
    {
        SprintNumber = sprintNumber;
        StartDate = startDate;
        EndDate = startDate.AddDays(durationDays);
    }

    public override void Add(Task newTask) => base.Add(newTask);
    public override void Remove(Task task) => base.Remove(task);
    public override IEnumerable<Task> GetAll() => base.GetAll();
}