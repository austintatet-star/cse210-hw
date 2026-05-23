using System;

// ===================================================================================
// CREATIVITY & EXCEEDING REQUIREMENTS REPORT:
// 1. STRETCH CHALLENGE: Optimized the hiding logic in Scripture.cs to ONLY pick words 
//    that are currently visible (`_words.Where(w => !w.IsHidden())`). This prevents 
//    wasted turns trying to hide already-hidden text blocks.
// 2. SCRIPTURE LIBRARY: Added a 'ScriptureLibrary' class initialized with a list of 
//    diverse verses. Every time the program runs, it selects a verse completely at random.
// 3. LIFELINE HINT SYSTEM: Added a utility where users can type 'hint' instead of 
//    pressing Enter. The program will temporarily reveal one hidden word to assist 
//    them if they get stuck mid-memorization.
// ===================================================================================
//I also missed the group meeting again. I did this by myself.

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("               SCRIPTURE MEMORIZER                  ");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("====================================================");
            
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Great job! You completely memorized the scripture!");
                break;
            }

            Console.Write("Press Enter to hide words, type 'hint' for help, or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
            else if (input == "hint")
            {
                scripture.RevealRandomWord();
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.WriteLine("\nProgram finished. Goodbye!");
    }
}