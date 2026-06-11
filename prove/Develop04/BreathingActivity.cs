using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    private int _breatheTime;
    private List<string> BreathePrompts = new List<string>();

    public BreathingActivity() : base(0)
    {
        SetName("Breathing Activity");
        Descriptions.Add("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public new void ChooseActivities()
    {
        DisplayDescription();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityLength());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            Console.WriteLine();
            
            Console.Write("Breathe out... ");
            ShowCountdown(6);
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