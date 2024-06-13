class BreathingActivity : Activity
{
    public BreathingActivity(string title, string description) : base(title, description)
    {
    
    }

    public void StartBreathingActivity(int duration)
    {
        StartActivity(duration);
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            elapsed += 4;
            if (elapsed >= duration)
                break;
            Console.Write("Breathe out... ");
            ShowCountdown(4);
            elapsed += 4;
        }
        EndActivity();
    }
}