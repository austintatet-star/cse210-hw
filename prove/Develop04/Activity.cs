using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    private string _name;
    protected List<string> Descriptions = new List<string>();
    protected int _activityLength;
    protected Random RandomChoice = new Random();

    public Activity(int activityLength)
    {
        _activityLength = activityLength;
    }

    public void ChooseActivities()
    {
    }

    public void DisplayDescription()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{Descriptions[0]}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityLength = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayTimer(5);
    }

    public void DisplayTimer(int seconds)
    {
        List<string> animationStrings = new List<string> { "/", "-", "\\", "|" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void DisplayEnd()
    {
        Console.WriteLine("\nWell done!!");
        DisplayTimer(3);
        Console.WriteLine($"You have completed another {_activityLength} seconds of the {_name}.");
        DisplayTimer(5);
    }

    public string GetRandomPrompt(List<string> promptsList)
    {
        int index = RandomChoice.Next(promptsList.Count);
        return promptsList[index];
    }

    public string GetRandomQuestion(List<string> questionsList)
    {
        int index = RandomChoice.Next(questionsList.Count);
        return questionsList[index];
    }

    public int GetActivityLength()
    {
        return _activityLength;
    }

    protected void SetName(string name)
    {
        _name = name;
    }
}