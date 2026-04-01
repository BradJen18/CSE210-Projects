using System;

public class Scripture
{
    private List<Word> _word = new List<Word>();
    private Reference _reference = new Reference();

    public void HideWords()
    {   
        Random random = new Random();
            foreach (Word w in _word)
            {
                int hide = random.Next(2);
                if (hide == 1)
                {
                    w.SetHidden(false);
                }
            }
        
    }
    public int CompleteHide()
    {
        int count = 0;
        foreach (Word w in _word)
        {
            count += 1;
        }
        int num = count;
            foreach (Word w in _word)
            {
                if (w.GetHidden() == false)
                {
                    num = num - 1;
                }
            }
        return num;
    }
    public void RenderText()
    {
        foreach (Word w in _word)
        {
            if (w.GetHidden() == true)
            {
                Console.Write($"{w.GetWord()} ");
            }
            else
            {
                Console.Write("_ ");
            }
        }
    }
    public void RenderReference()
    {
        if (_reference.GetEndVerse() != 0)
        {
            string book = _reference.GetBook();
            int chapter = _reference.GetChapter();
            int verse = _reference.GetVerse();
            int endVerse = _reference.GetEndVerse();

            Console.WriteLine($"{book} {chapter}:{verse}-{endVerse}");
        }
        else
        {
            string book = _reference.GetBook();
            int chapter = _reference.GetChapter();
            int verse = _reference.GetVerse();
            Console.WriteLine($"{book} {chapter}:{verse}");

        }

    }

    public void RenderAll()
    {
        RenderReference();
        RenderText();
    }

    public void SetReference1(string book, int chapter, int verse)
    {
        _reference.SetBook(book);
        _reference.SetChapter(chapter);
        _reference.SetVerse(verse);
    }
    public void SetReference2(string book, int chapter, int verse, int endVerse)
    {
        _reference.SetBook(book);
        _reference.SetChapter(chapter);
        _reference.SetVerse(verse);
        _reference.SetEndVerse(endVerse);
    }
    public void SetWords(string scripture)
    {   
        string phrase = scripture;
        string separator = " ";
        string [] words = phrase.Split(separator);
        foreach (string w in words)
        {
            Word word = new Word(w, true);
            _word.Add(word);
        }
    }
    
}

