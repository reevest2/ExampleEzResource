using GenEzResource.Models;

namespace ExampleEzresource.Models;

public class TaskItem : ResourceBase
{
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public DateTime DueDate { get; set; } = DateTime.Now.AddDays(1);
}
