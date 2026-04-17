using TaskTrackerCLI.Commands.TaskProperties;

namespace TaskTrackerCLI.Data.Commands;

public static class Add
{
    public static void AddTask(List<TaskItem> tasks, string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Missing description");
            return;
        }

        var task = new TaskItem()
        {
            Id = tasks.Any() ? tasks.Max(t => t.Id) + 1 : 1,
            Description = args[1],
            Status = "todo",
            Created = DateTime.Now,
            LastModified = DateTime.Now
        };

        tasks.Add(task);
        Console.WriteLine($"Task added (ID: {task.Id})");
    }
}