using System;

public class Scripture
{
    private List<Word> _word = new List<Word>();
    private Reference _reference = new Reference();

    

    public void HideWords()
    {
        
        int count = 0;
        foreach (Word w in _word) // Count all words in the scripture, use count to randomly pick a word in the list. when random word is picked, change "hidden" to a 1 by doing "hidden = 1"
        {
            count += 1;
        }
        Console.WriteLine(count);

        Random random = new Random();
        int number = random.Next(count); // need to find out how to single out a word in a list & chaince the value.

    }
    public void RenderText()
    {
        
    }
    public void RenderReference()
    {
        string book = _reference.GetBook();
        int chapter = _reference.GetChapter();
        int verse = _reference.GetVerse();
        int endVerse = _reference.GetEndVerse();

        Console.WriteLine($"{book} {chapter}:{verse} {endVerse}");

    }
}

