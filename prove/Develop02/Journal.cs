using System;
using System.IO; 

public class Journal
{
    public List<UserEntry> _entries = new List<UserEntry>();
    public GetPrompt _randomPrompt = new GetPrompt();

    public void AddEntry()
    {
        string prompt = _randomPrompt.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        UserEntry entry = new UserEntry { _entryDateTime = date, _givenPrompt = prompt, _entryText = response };
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (UserEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (UserEntry entry in _entries)
                {
                    writer.WriteLine($"{entry._entryDateTime}|{entry._givenPrompt}|{entry._entryText}");
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
        }
    }
    

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("The specified file was not found.", filename);
            }

            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        UserEntry entry = new UserEntry { _entryDateTime = parts[0], _givenPrompt = parts[1], _entryText = parts[2] };
                        _entries.Add(entry);
                    }
                    else
                    {
                        throw new FormatException("File format is incorrect.");
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The specified file was not found.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
