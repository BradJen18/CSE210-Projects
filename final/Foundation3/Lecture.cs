class Lecture : Event
{
    private string _Speaker;
    private string _Capacity;
    public string GetSpeaker()
    {
        return _Speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _Speaker = speaker;
    }
    public string GetCapacity()
    {
        return _Capacity;
    }
    public void SetCapacity(string capacity)
    {
        _Capacity = capacity;
    }
    public override void Full()
    {
        Console.WriteLine($"{_Speaker},{_Capacity},{GetType()}, {GetTitle()}, {GetDesc()}, {GetDate()}, {GetTime()}");
        Display();
        Console.WriteLine();
    }
    public Lecture()
    {
        _Speaker = "Chuck Norris";
        _Capacity = "100";
    }
    public Lecture(string type, string title, string desc, string date, string time, string speaker, string capacity) : base(type, title, desc, date, time)
    {
        _Speaker = speaker;
        _Capacity = capacity;
    }
}