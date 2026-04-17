using System.Globalization;
using TaskTrackerCLI.Commands.TaskProperties;

namespace TaskTrackerCLI.Data.Commands;

public class Mark
{
    /*private readonly List<TaskItem> tasks;
    private readonly string message;
    private readonly string[]  args;*/
    public Mark(List<TaskItem> tasks, string[] args, string message)
    {
        /*this.tasks = tasks;
        this.message = message;
        this.args = args;*/
        
        MarkDone(tasks, args,message);
    }

    private static void MarkDone(List<TaskItem> tasks, string[] args,string message)
    {
        int id = int.Parse(args[1]);
        
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task == null) 
        {
            Console.WriteLine($" Task of {id} | not found");
            return;
        }

        task.Status = message;
        task.LastModified = DateTime.Now;
        Console.WriteLine($"Marked as {message}  || {task.Id} | {task.Description} | {task.Status}");   
    }
}


public class MarkDone : Mark
{
    public MarkDone(List<TaskItem> tasks, string[] args) :
        base(tasks, args, "done")  {}
}

public class MarkProgressTask : Mark
{
    public MarkProgressTask(List<TaskItem> tasks, string[] args) :
        base(tasks, args, "in-progress")  {}
}