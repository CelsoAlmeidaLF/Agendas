namespace Scrum.Core;

public class Sprint : EntityBase
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Epicos?> Epicos { get; }

    public Sprint(
        int sprintNumber, string titulo, string descrição, DateTime startDate, int durationDays)
    {
        ID = sprintNumber;
        Title = titulo;
        Description = descrição;
        StartDate = startDate;
        EndDate = startDate.AddDays(durationDays);
        Epicos = new();
    }

    public Sprint Add(Epicos? epico)
    {
        Epicos.Add(epico);
        return this;
    }

    public Sprint Clear()
    {
        Epicos.Clear();
        return this;
    }
}
