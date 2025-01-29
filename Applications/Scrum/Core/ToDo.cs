
namespace Scrum.Core;

public sealed class ToDo(int id, string title, string description, ItemStatus status = ItemStatus.ToDo)
{
    public int ID { get; set; } = id;
    public string Title { get; } = title;
    public string Description { get; } = description;
    public ItemStatus Status { get; set; } = status; // e.g., "To Do", "In Progress", "Done"
}