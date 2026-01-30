using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _input;
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - {_prompt}:");
        Console.WriteLine($"{_input}");
    }
}