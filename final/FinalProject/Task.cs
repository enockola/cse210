public abstract class Task
{
    protected string _taskDescription;
    protected string _taskPriority;
    protected string _taskDate;

    public Task(string taskDescription, string taskPriority, string taskDate)
    {
        _taskDescription = taskDescription;
        _taskPriority = taskPriority;
        _taskDate = taskDate;
    }

    public string TaskDescription
    {
        get { return _taskDescription; }
        set { _taskDescription = value; }
    }

    public string TaskPriority
    {
        get { return _taskPriority; }
        set { _taskPriority = value; }
    }

    public override string ToString()
    {
        return $"{_taskDescription} (Priority: {_taskPriority}, Date: {_taskDate})";
    }
}