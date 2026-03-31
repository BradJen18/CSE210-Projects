class Reception : Event
{
    private string _RSVP;
    public string GetRSVP()
    {
        return _RSVP;
    }
    public void SetRSVP(string RSVP)
    {
        _RSVP = RSVP;
    }
    public override void Full()
    {
        Console.WriteLine("Full: ");
        Console.WriteLine(Gettype());
        Console.WriteLine($"RSVP at: {_RSVP}");
        Console.WriteLine($"'{GetTitle()}', {GetDesc()}, {GetDate()}, {GetTime()}");
        Display();
        Console.WriteLine();

    }
    public Reception()
    {
        _RSVP = "BillGates123@gmail.com";
    }
    public Reception(string type, string title, string desc, string date, string time, string RSVP) : base(type, title, desc, date, time)
    {
        _RSVP = RSVP;
    }
}