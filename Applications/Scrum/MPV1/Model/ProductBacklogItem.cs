namespace Scrum.MPV1.Model;

public class ProductBacklogItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public ItemStatus Status { get; set; } // e.g., "To Do", "In Progress", "Done"
}

public enum ItemStatus
{
    ToDo,
    InProgress,
    Done
}
