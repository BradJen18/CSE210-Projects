using System;

class WritingAssignment : Assignment
{
    private string _title;

    public string GetWritingInformation()
    {
        string name = GetName();
        return $"{_title} by {name}";
    }

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {   
        _title = title;
    }
}