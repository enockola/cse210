using System;

public class UserEntry
{
    public string _givenPrompt;
    public string _entryText;
    public string _entryDateTime;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_entryDateTime} - Prompt: {_givenPrompt}");
        Console.WriteLine($"{_entryText}");
    }
}