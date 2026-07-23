using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
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
                    string prompt = promptGenerator.GetRandomPrompt();
                    
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Console.Write("Rate your day's mood (1-5, where 5 is amazing): ");
                    string mood = Console.ReadLine();

                    string dateText = DateTime.Now.ToString("yyyy-MM-dd");

                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;
                    newEntry._mood = mood;

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