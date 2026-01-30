using System;

public class Journal
{
    public List<Entry> _entry = new List<Entry>();
    public int _password;

    public void DisplayJournal()
    {
        foreach (Entry i in _entry)
        {
            i.DisplayEntry();   
        }
    }

}