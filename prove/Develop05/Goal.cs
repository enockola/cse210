
public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _points = points;
        _isCompleted = false;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool GetIsCompleted()
    {
        return _isCompleted;
    }

    public abstract void DisplayInfo();
    public abstract void RecordEvent();

    internal ReadOnlySpan<char> Serialize()
    {
        throw new NotImplementedException();
    }

    internal static Goal Deserialize(string line)
    {
        throw new NotImplementedException();
    }
}
