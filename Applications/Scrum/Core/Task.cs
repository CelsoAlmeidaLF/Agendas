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
