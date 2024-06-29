public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"Completed: {_goalName} (+{_points} points)");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine(_isCompleted ? $"[X] {_goalName} (+{_points} points)" : $"[ ] {_goalName} (+{_points} points)");
    }
}
