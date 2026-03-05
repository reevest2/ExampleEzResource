using GenEzResource.Models;

namespace ExampleEzresource.Models;

public class Project : ResourceBase
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.Now;
}
