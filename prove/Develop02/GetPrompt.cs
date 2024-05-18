using System;

public class GetPrompt
{
    public List<string> _prompt = new List<string>(){
        "What are three things I'm grateful for today?",
        "What are three things I'm looking forward to tomorrow?",
        "What is one thing I'm proud of myself for today?",
        "How did I take care of myself today (physically, mentally, emotionally)?",
        "What is one thing I could have done better today?",
        "How did I show kindness or help someone today?",
        "What is one small victory I achieved today?",
        "What made me smile or laugh today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}