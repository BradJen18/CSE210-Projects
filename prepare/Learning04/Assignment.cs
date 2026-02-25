using System;
class Assignment
{
    private string _studentName;
    private string _topic;

    public string GetName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        string summary = $"{GetName()} - {GetTopic()}";
        return summary;
    }

    public Assignment()
    {
        _studentName = "";
        _topic = "";
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    
}
