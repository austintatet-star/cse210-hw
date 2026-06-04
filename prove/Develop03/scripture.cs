using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        List<Word> visibleWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
        }

        int actualToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < actualToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public void RevealRandomWord()
    {
        List<Word> hiddenWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (w.IsHidden())
            {
                hiddenWords.Add(w);
            }
        }

        if (hiddenWords.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(hiddenWords.Count);
            hiddenWords[randomIndex].Show();
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", displayWords);
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}