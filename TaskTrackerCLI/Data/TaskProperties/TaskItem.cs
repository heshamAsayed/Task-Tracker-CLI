namespace TaskTrackerCLI.Commands.TaskProperties;

public class TaskItem
{
    public int Id {get; set;}
    public string Description {get; set;}
    public string Status {get; set;}
    public DateTime Created {get; set;}
    public DateTime LastModified {get; set;}
    
}