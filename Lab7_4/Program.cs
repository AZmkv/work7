using Lab7_4;

class Program
{
    static void Main()
    {
        CustomTaskScheduler<string, int> scheduler = new CustomTaskScheduler<string, int>(task => task.Length);

        scheduler.AddTask("Task 1");
        scheduler.AddTask("Task 2");
        scheduler.AddTask("Task 3");

        Console.WriteLine("Executing tasks:");
        scheduler.ExecuteNext(task => Console.WriteLine($"Executing: {task}"));

        scheduler.AddTask("Task 4");
        scheduler.AddTask("Task 5");

        Console.WriteLine("\nExecuting next task:");
        scheduler.ExecuteNext(task => Console.WriteLine($"Executing: {task}"));

        Console.WriteLine("\nRemaining tasks in the queue:");
        var remainingTasks = scheduler.GetTasks();
        foreach (var task in remainingTasks)
        {
            Console.WriteLine(task);
        }
    }
}