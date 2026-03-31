using System;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word()
    {
        _word = "";
        _hidden = false;
    }
    public Word(string word, bool hidden)
    {
        _word = word;
        _hidden = hidden;
    }

    public string GetWord()
    {
        return _word;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public bool GetHidden()
    {
        return _hidden;
    }
    public void SetHidden(bool hidden)
    {
        _hidden = hidden;
    }
}