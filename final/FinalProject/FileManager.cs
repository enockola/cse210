public class FileManager
{
    private const string TaskFilePath = "tasklist.txt";

    public List<Task> LoadTasks()
    {
        List<Task> tasks = new List<Task>();
        CompletedTask completedTask = new CompletedTask();

        if (!File.Exists(TaskFilePath))
        {
            return tasks;
        }

        using (StreamReader reader = new StreamReader(TaskFilePath))
        {
            string line;
            bool isCompleted = false;

            while ((line = reader.ReadLine()) != null)
            {
                if (line == "CompletedTasks:")
                {
                    isCompleted = true;
                    continue;
                }

                string[] parts = line.Split('|');
                if (parts.Length >= 4)
                {
                    string type = parts[0];
                    string description = parts[1];
                    string priority = parts[2];
                    string date = parts[3];
                    string extraInfo = parts.Length > 4 ? parts[4] : string.Empty;

                    Task task = null;
                    switch (type)
                    {
                        case "Chore":
                            task = new Chore(description, priority, date, extraInfo);
                            break;
                        case "Schedule":
                            task = new Schedule(description, priority, date);
                            break;
                        case "Recurring":
                            task = new Recurring(description, priority, date, extraInfo);
                            break;
                        case "Reminder":
                            task = new Reminder(description, priority, date);
                            break;
                    }

                    if (task != null)
                    {
                        if (isCompleted)
                        {
                            completedTask.AddCompletedTask(task);
                        }
                        else
                        {
                            tasks.Add(task);
                        }
                    }
                }
            }
        }
        return tasks;
    }

    public void SaveTasks(List<Task> tasks, List<Task> completedTasks)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(TaskFilePath))
            {
                foreach (Task task in tasks)
                {
                    writer.WriteLine($"{task.GetType().Name}|{task.GetTaskDescription()}|{task.GetTaskPriority()}|{task.GetTaskDate()}|{task.GetExtraInfo()}");
                }
                writer.WriteLine("CompletedTasks:");
                foreach (Task task in completedTasks)
                {
                    writer.WriteLine($"{task.GetType().Name}|{task.GetTaskDescription()}|{task.GetTaskPriority()}|{task.GetTaskDate()}|{task.GetExtraInfo()}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An error occurred while saving tasks: {ex.Message}");
        }
    }
}
