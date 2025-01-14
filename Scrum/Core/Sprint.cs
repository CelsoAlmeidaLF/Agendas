namespace Systekna.Scrum.Core;

public class Sprint
{
    public int SprintNumber { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Task> Tasks { get; }
    public string Titulo { get; set; }
    public string Descrição { get; set; }

    public Sprint(int sprintNumber, string titulo, string descrição, DateTime startDate, int durationDays)
    {
        SprintNumber = sprintNumber;
        Titulo = titulo;
        Descrição = descrição;
        StartDate = startDate;
        EndDate = startDate.AddDays(durationDays);
        Tasks = new List<Task>();
    }
}
