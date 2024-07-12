public class Tasklist
{
    private List<Task> _tasks = new List<Task>();

    public void AddTask(Task task)
    {
        _tasks.Add(task);
    }

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < _tasks.Count)
        {
            _tasks.RemoveAt(index);
        }
    }

    public void UpdateTask(int index, string newDescription, string newPriority)
    {
        if (index >= 0 && index < _tasks.Count)
        {
            _tasks[index].TaskDescription = newDescription;
            _tasks[index].TaskPriority = newPriority;
        }
    }

    public void CompleteTask(int index, CompletedTaskList completedTaskList)
    {
        if (index >= 0 && index < _tasks.Count)
        {
            completedTaskList.AddCompletedTask(_tasks[index]);
            _tasks.RemoveAt(index);
        }
    }

    public void PrintAllTasks()
    {
        Console.WriteLine("\nIncomplete Tasks:");
        for (int i = 0; i < _tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_tasks[i]}");
        }
    }

    public int GetTaskCount()
    {
        return _tasks.Count;
    }
}