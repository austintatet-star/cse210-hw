//I think I did everything right.

using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class Entry
    {
        public string Date { get; set; }
        public string PromptText { get; set; }
        public string EntryText { get; set; }
        public string Mood { get; set; }

        public Entry(string date, string promptText, string entryText, string mood)
        {
            Date = date;
            PromptText = promptText;
            EntryText = entryText;
            Mood = mood;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
            Console.WriteLine($"Mood: {Mood}/5");
            Console.WriteLine($"Response: {EntryText}");
            Console.WriteLine(new string('-', 50));
        }

        public string ExportToCsvLine()
        {
            return $"{Date}~|~{PromptText}~|~{EntryText}~|~{Mood}";
        }
    }

    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();

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
            foreach (var entry in _entries)
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
                    foreach (var entry in _entries)
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
                    string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
                    
                    if (parts.Length == 4)
                    {
                        Entry loadedEntry = new Entry(parts[0], parts[1], parts[2], parts[3]);
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

    class Program
    {
        private static List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned or realized today?",
            "What made me smile or laugh out loud today?"
        };

        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            Random random = new Random();
            bool running = true;

            Console.WriteLine("Welcome to your Personal Journal Program!");

            while (running)
            {
                Console.WriteLine("\nPlease select one of the following choices:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Load the journal from a file");
                Console.WriteLine("4. Save the journal to a file");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        int index = random.Next(_prompts.Count);
                        string prompt = _prompts[index];
                        
                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("> ");
                        string response = Console.ReadLine();

                        Console.Write("Rate your day's mood (1-5, where 5 is amazing): ");
                        string mood = Console.ReadLine();

                        string dateText = DateTime.Now.ToString("yyyy-MM-dd");

                        Entry newEntry = new Entry(dateText, prompt, response, mood);
                        myJournal.AddEntry(newEntry);
                        break;

                    case "2":
                        myJournal.DisplayAll();
                        break;

                    case "3":
                        Console.Write("What is the filename? ");
                        string loadFile = Console.ReadLine();
                        myJournal.LoadFromFile(loadFile);
                        break;

                    case "4":
                        Console.Write("What is the filename? ");
                        string saveFile = Console.ReadLine();
                        myJournal.SaveToFile(saveFile);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye! Keep writing.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please enter a number from 1 to 5.");
                        break;
                }
            }
        }
    }
}