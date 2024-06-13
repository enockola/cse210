class ListingActivity : Activity
{
    private List<string> _prompts;
    public ListingActivity(string title, string description) : base(title, description)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void StartListingActivity(int duration)
    {
        StartActivity(duration);
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinnerAnimation(5);
        DateTime startTime = DateTime.Now;
        List<string> items = new List<string>();
        Console.WriteLine("Start listing items:");
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string item = Console.ReadLine();
            if ((DateTime.Now - startTime).TotalSeconds >= duration)
                break;
            items.Add(item);
        }
        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity();
    }
}