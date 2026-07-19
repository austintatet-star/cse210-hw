using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- PROGRAM 4: POLYMORPHISM WITH EXERCISE TRACKING ---");
        
        List<Activity> activityList = new List<Activity>();

        activityList.Add(new Running("18 Jul 2026", 30, 3.0f));
        activityList.Add(new Cycling("19 Jul 2026", 45, 12.0f));
        activityList.Add(new Swimming("20 Jul 2026", 20, 24));

        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity);
        }
    }
}