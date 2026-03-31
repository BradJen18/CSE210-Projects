class Outdoor : Event
{
    private string _Weather;
    public string GetWeather()
    {
        return _Weather;
    }
    public void SetWeather(string weather)
    {
        _Weather = weather;
    }
    public override void Full()
    {
        Console.WriteLine($"{_Weather}, {GetType()}, {GetTitle()}, {GetDesc()}, {GetDate()}, {GetTime()}");
        Display();   
        Console.WriteLine();

    }
    public Outdoor()
    {
        _Weather = "Sunny";
    }
    public Outdoor(string type, string title, string desc, string date, string time, string weather) : base(type, title, desc, date, time)
    {
        _Weather = weather;
    }
}