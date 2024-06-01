using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private Random _random;

    public Scripture(string referenceText, string scriptureText)
    {
        _reference = new Reference(referenceText);
        _words = new List<Word>();
        foreach (var word in scriptureText.Split(' '))
        {
            _words.Add(new Word(word));
        }
        _random = new Random();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = GetVisibleWords();
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count; i++)
        {
            if (visibleWords.Count == 0) break;
            int indexToHide = _random.Next(visibleWords.Count);
            visibleWords[indexToHide].Hide();
            visibleWords.RemoveAt(indexToHide);
        }
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (word.IsVisible())
            {
                return false;
            }
        }
        return true;
    }

    public void Display()
    {
        Console.Write(_reference + " ");
        foreach (var word in _words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    private List<Word> GetVisibleWords()
    {
        var visibleWords = new List<Word>();
        foreach (var word in _words)
        {
            if (word.IsVisible())
            {
                visibleWords.Add(word);
            }
        }
        return visibleWords;
    }
}
