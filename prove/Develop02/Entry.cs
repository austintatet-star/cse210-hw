using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}/5");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine(new string('-', 50));
    }

    public string ExportToCsvLine()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}~|~{_mood}";
    }
}