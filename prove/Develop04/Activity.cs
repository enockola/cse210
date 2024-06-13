class Activity
{
    protected string _title;
    protected string _description;
    protected int _duration;

    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public void StartActivity(int duration)
    {
        Console.Clear();
        Console.WriteLine($"Starting {_title}\n");
        Console.WriteLine(_description);
        _duration = duration;
        Console.WriteLine($"Duration: {_duration} seconds");
        Thread.Sleep(2000);
        Console.Write("\nGet Ready...");
        ShowSpinnerAnimation(10);
    }

    public void EndActivity()
    {
        Console.WriteLine($"You have completed the {_title} activity");
        Thread.Sleep(2000);
        Console.WriteLine($"Activity Duration: {_duration} seconds");
        ShowSpinnerAnimation(5);
    }

    public void ShowSpinnerAnimation(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");


        foreach (string item in animationStrings)
        {
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b \b");
        }
        Console.WriteLine();
    }
}