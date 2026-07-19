using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- PROGRAM 3: INHERITANCE WITH EVENT PLANNING ---");
        
        EventAddress address1 = new EventAddress("123 Lecture Hall Way", "Rexburg", "ID", "83440");
        Lecture lectureEvent = new Lecture("Introduction to C#", "An in-depth look at object-oriented programming concepts.", "07/20/2026", "7:00 PM", address1, "Dr. Smith", 150);

        EventAddress address2 = new EventAddress("456 Celebration Lane", "Salt Lake City", "UT", "84101");
        Reception receptionEvent = new Reception("Tech Networking Gala", "An evening to connect with industry professionals.", "08/15/2026", "6:30 PM", address2, "rsvp@techgala.com");

        EventAddress address3 = new EventAddress("789 Park Place", "Boise", "ID", "83702");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Community Fun Run", "A casual 5k run through the local park trails.", "09/05/2026", "8:00 AM", address3, "Sunny with a light breeze, high of 75°F");

        Console.WriteLine("========================================");
        Console.WriteLine(lectureEvent); 
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetShortDescription("Lecture"));
        Console.WriteLine("========================================");

        Console.WriteLine(receptionEvent); 
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetShortDescription("Reception"));
        Console.WriteLine("========================================");

        Console.WriteLine(outdoorEvent); 
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetShortDescription("Outdoor Gathering"));
        Console.WriteLine("========================================");
    }
}