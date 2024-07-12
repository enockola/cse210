public class CompletedTaskList
{
    private List<Task> _completedTasks = new List<Task>();

    public void AddCompletedTask(Task task)
    {
        _completedTasks.Add(task);
    }

    public void PrintAllCompletedTasks()
    {
        Console.WriteLine("\nCompleted Tasks:");
        for (int i = 0; i < _completedTasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_completedTasks[i]}");
        }
    }
}