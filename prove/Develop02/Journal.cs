using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nYour journal is currently empty.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.ExportToCsvLine());
                }
            }
            Console.WriteLine($"Journal successfully saved to {file}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("File not found. Please check the filename and try again.");
                return;
            }

            _entries.Clear();

            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                
                if (parts.Length == 4)
                {
                    Entry loadedEntry = new Entry();
                    loadedEntry._date = parts[0];
                    loadedEntry._promptText = parts[1];
                    loadedEntry._entryText = parts[2];
                    loadedEntry._mood = parts[3];

                    _entries.Add(loadedEntry);
                }
            }
            Console.WriteLine($"Journal successfully loaded from {file}. {_entries.Count} entries restored.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
        }
    }
}