using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // methods
    public void DisplayResumeName()
    {
        Console.WriteLine($"Name: {_name}");
    }

    public void DisplayResumeJobs()
    { 
        Console.WriteLine($"Jobs: ");
        foreach (Job job in _jobs){
            job.DisplayJobDetails();
        }
    }
}