using System;
using System.Collections.Generic;

public class EnumerationActivity : Activity
{
    private int _enumerationTime;
    private int _reminderTime;
    private List<string> _entryList = new List<string>();
    private string _reminder;
    private List<string> Questions = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public EnumerationActivity() : base(0)
    {
        SetName("Enumeration Activity");
        Descriptions.Add("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public new void ChooseActivities()
    {
        DisplayDescription();

        string chosenQuestion = GetRandomQuestion(Questions);
        Console.WriteLine("\nList as many items as you can for the following prompt:");
        Console.WriteLine($"--- {chosenQuestion} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityLength());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _entryList.Add(item);
        }

        Console.WriteLine($"You listed {_entryList.Count} items!");
        DisplayEnd();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}