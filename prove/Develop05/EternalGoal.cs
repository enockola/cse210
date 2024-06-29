public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded: {_goalName} (+{_points} points)");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[∞] {_goalName} (+{_points} points each time)");
    }
}
