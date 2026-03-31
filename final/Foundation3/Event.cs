class Event
{
    private string _Title;
    private string _Desc;
    private string _Date;
    private string _Time;
    private string _Type;
    private Address address = new Address();

    public string GetTitle()
    {
        return _Title;
    }
    public void SetTitle(string title)
    {
        _Title = title;
    }
    public string GetDesc()
    {
        return _Desc;
    }
    public void SetDesc(string desc)
    {
        _Desc = desc;
    }
    public string GetDate()
    {
        return _Date;
    }
    public void SetDate(string date)
    {
        _Date = date;
    }
    public string GetTime()
    {
        return _Time;
    }
    public void SetTime(string time)
    {
        _Time = time;
    }
    public string Gettype()
    {
        return _Type;
    }
    public void SetType(string type)
    {
        _Type = type;
    }

    public void SetAddress(string ad, string city, string state, string country)
    {
        address.SetStreetAd(ad);
        address.SetCity(city);
        address.SetState(state);
        address.SetCountry(country);        
    }
    public void Display()
    {
        address.DisplayAd();
    }

    public void Standard()
    {
        Console.WriteLine("Standard: ");
        Console.WriteLine($"'{_Title}', {_Desc}, {_Date}, {_Time}");
        Display();
        Console.WriteLine();
    }
    public virtual void Full() // Override in each Child class to match specifications
    {
        Console.WriteLine("Full: ");
        Console.WriteLine($"{_Type}, {_Title}, {_Desc}, {_Date}, {_Time}, {address}");
        Console.WriteLine();
    }
    public void Short()
    {
        Console.WriteLine("Short: ");
        Console.WriteLine($"{_Type}, {_Title}, {_Date}");
        Console.WriteLine();
    }

    public Event()
    {
        _Type = "Reception";
        _Title = "Effective leadership";
        _Desc = "Discussing the key points of a effective leader in the work place";
        _Date = "10/25/2026";
        _Time = "8:30 am";
    }
     public Event(string type, string title, string desc, string date, string time)
    {
        _Type = type;
        _Title = title;
        _Desc = desc;
        _Date = date;
        _Time = time;
    }
}