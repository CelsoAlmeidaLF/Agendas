namespace Scrum.Core;

public sealed class Epicos(int id, string title, string description, ItemStatus status = ItemStatus.ToDo)
    : Backlog(id, title, description, status)
{
}