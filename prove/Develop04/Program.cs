using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start enumeration activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.ChooseActivities();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.ChooseActivities();
            }
            else if (choice == "3")
            {
                EnumerationActivity enumeration = new EnumerationActivity();
                enumeration.ChooseActivities();
            }
            else if (choice == "4")
            {
                keepRunning = false;
            }
        }
    }
}