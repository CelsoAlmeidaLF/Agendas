namespace Scrum.Core;

public class Backlog : EntityBase
{
    public ItemStatus Status { get; set; } // e.g., "To Do", "In Progress", "Done"
    public List<ToDo> Tasks { get; set; } 
    public Backlog (int id, string title, string description, ItemStatus status = ItemStatus.ToDo)
    {
        ID = id;
        Title = title;
        Description = description;
        Status = status;
        Tasks = new List<ToDo>() { 
            new ToDo(0, title, description) 
        };
    }
}

public enum ItemStatus
{
    ToDo,
    InProgress,
    Done
}
