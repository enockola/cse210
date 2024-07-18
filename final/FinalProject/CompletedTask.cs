public class CompletedTask
{
    private List<Task> _completedTasks = new List<Task>();
    
    public List<Task> GetAllCompletedTasks()
    {
        return _completedTasks;
    }

    public void AddCompletedTask(Task task)
    {
        _completedTasks.Add(task);
    }

    public void PrintAllCompletedTasks()
    {
        Console.Clear();
        Console.WriteLine("\nCompleted Tasks:");
        for (int i = 0; i < _completedTasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_completedTasks[i]}");
        }
    }
}