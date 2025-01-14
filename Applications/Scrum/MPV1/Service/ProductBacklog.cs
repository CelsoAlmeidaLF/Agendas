namespace Scrum.MPV1.Service;

using Scrum.MPV1.Model;
using System;
using System.Collections.Generic;
using System.Linq;

public class ProductBacklog
{
    private List<ProductBacklogItem> items;
    private List<Sprint> sprints;
    private int nextItemId;
    private int nextSprintId;

    public ProductBacklog()
    {
        items = new List<ProductBacklogItem>();
        sprints = new List<Sprint>();
        nextItemId = 1;
        nextSprintId = 1;
    }

    // Métodos para gerenciar itens do backlog
    public void AddItem(string title, string description, ItemStatus status)
    {
        if (string.IsNullOrEmpty(title))
        {
            Console.WriteLine("Title and status are required.");
            return;
        }

        var item = new ProductBacklogItem
        {
            Id = nextItemId++,
            Title = title,
            Description = description,
            Status = status
        };
        items.Add(item);
    }

    public void UpdateItem(int id, string title, string description, ItemStatus status)
    {
        var item = items.FirstOrDefault(i => i.Id == id);
        if (item != null)
        {
            item.Title = title;
            item.Description = description;
            item.Status = status;
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    public void RemoveItem(int id)
    {
        var item = items.FirstOrDefault(i => i.Id == id);
        if (item != null)
        {
            items.Remove(item);
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    public void ViewBacklog()
    {
        Console.WriteLine("Product Backlog:");
        foreach (var item in items)
        {
            Console.WriteLine($"ID: {item.Id}, Title: {item.Title}, Description: {item.Description}, Status: {item.Status}");
        }
    }

    // Métodos para gerenciar sprints
    public void AddSprint(string name, DateTime startDate, DateTime endDate)
    {
        var sprint = new Sprint
        {
            Id = nextSprintId++,
            Name = name,
            StartDate = startDate,
            EndDate = endDate
        };
        sprints.Add(sprint);
    }

    public void UpdateSprint(int id, string name, DateTime startDate, DateTime endDate)
    {
        var sprint = sprints.FirstOrDefault(s => s.Id == id);
        if (sprint != null)
        {
            sprint.Name = name;
            sprint.StartDate = startDate;
            sprint.EndDate = endDate;
        }
        else
        {
            Console.WriteLine("Sprint not found.");
        }
    }

    public void RemoveSprint(int id)
    {
        var sprint = sprints.FirstOrDefault(s => s.Id == id);
        if (sprint != null)
        {
            sprints.Remove(sprint);
        }
        else
        {
            Console.WriteLine("Sprint not found.");
        }
    }

    public void ViewSprints()
    {
        Console.WriteLine("Sprints:");
        foreach (var sprint in sprints)
        {
            Console.WriteLine($"ID: {sprint.Id}, Name: {sprint.Name}, Start Date: {sprint.StartDate.ToShortDateString()}, End Date: {sprint.EndDate.ToShortDateString()}");
            Console.WriteLine("  Items:");
            foreach (var item in sprint.SprintBacklog)
            {
                Console.WriteLine($"    ID: {item.Id}, Title: {item.Title}, Status: {item.Status}");
            }
        }
    }

    public void ViewSchedule()
    {
        Console.WriteLine("Scrum Schedule:");

        // Visualizar sprints
        foreach (var sprint in sprints)
        {
            Console.WriteLine($"Sprint ID: {sprint.Id}, Name: {sprint.Name}, Start Date: {sprint.StartDate.ToShortDateString()}, End Date: {sprint.EndDate.ToShortDateString()}");
            Console.WriteLine("  Items:");
            foreach (var item in sprint.SprintBacklog)
            {
                Console.WriteLine($"    ID: {item.Id}, Title: {item.Title}, Status: {item.Status}");
            }
        }

        // Visualizar backlog completo
        Console.WriteLine("Product Backlog:");
        foreach (var item in items)
        {
            Console.WriteLine($"ID: {item.Id}, Title: {item.Title}, Description: {item.Description}, Status: {item.Status}");
        }
    }

    public void AddItemToSprintBacklog(int sprintId, int itemId)
    {
        var sprint = sprints.FirstOrDefault(s => s.Id == sprintId);
        var item = items.FirstOrDefault(i => i.Id == itemId);
        if (sprint != null && item != null)
        {
            sprint.SprintBacklog.Add(item);
        }
        else
        {
            Console.WriteLine("Sprint or Item not found.");
        }
    }

    public void ViewSprintBacklog(int sprintId)
    {
        var sprint = sprints.FirstOrDefault(s => s.Id == sprintId);
        if (sprint != null)
        {
            Console.WriteLine($"Sprint Backlog for Sprint ID: {sprint.Id}, Name: {sprint.Name}");
            foreach (var item in sprint.SprintBacklog)
            {
                Console.WriteLine($"    ID: {item.Id}, Title: {item.Title}, Status: {item.Status}");
            }
        }
        else
        {
            Console.WriteLine("Sprint not found.");
        }
    }
}
