using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _library;

    public ScriptureLibrary()
    {
        _library = new List<Scripture>();
        LoadDefaultScriptures();
    }

    private void LoadDefaultScriptures()
    {
        _library.Add(new Scripture(
            new Reference("John", 3, 16), 
            "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"
        ));

        _library.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6), 
            "Trust in the LORD with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight"
        ));

        _library.Add(new Scripture(
            new Reference("Philippians", 4, 13), 
            "I can do all this through him who gives me strength"
        ));

        _library.Add(new Scripture(
            new Reference("Joshua", 1, 9), 
            "Have I not commanded you Be strong and courageous Do not be afraid do not be discouraged for the LORD your God will be with you wherever you go"
        ));
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_library.Count);
        return _library[index];
    }
}