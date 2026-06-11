using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private int _reflectionTime;
    private List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base(0)
    {
        SetName("Reflection Activity");
        Descriptions.Add("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public new void ChooseActivities()
    {
        DisplayDescription();

        string chosenPrompt = GetRandomPrompt(Prompts);
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {chosenPrompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityLength());

        while (DateTime.Now < endTime)
        {
            string chosenQuestion = GetRandomQuestion(Questions);
            Console.Write($"\n> {chosenQuestion} ");
            DisplayTimer(5);
            Console.WriteLine();
        }

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