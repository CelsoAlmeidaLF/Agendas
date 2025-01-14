namespace Scrum.MPV1.Model;

public class Sprint
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<ProductBacklogItem> SprintBacklog { get; set; }

    public Sprint()
    {
        SprintBacklog = new List<ProductBacklogItem>();
    }
}
