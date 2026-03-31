class Running : Activity
{
    private double _Distance; 

    public double GetDistance()
    {
        return _Distance;
    }
    public void SetDistance(double distance)
    {
        _Distance = distance;
    }
    public Running()
    {
        _Distance = 0;
    }
    public Running(string date, int length, string type, double distance) : base (date, length, type)
    {
        _Distance = distance;
    }

    public override double CalcSpeed()
    {
        int _Length = GetLength();
        double speed = (_Distance / _Length) * 60;
        return speed;
    }
    public override double CalcPace()
    {
        int length = GetLength();
        double pace = length / _Distance;
        return pace;
    }
    public override void GetSummary()
    {
        Console.WriteLine($" - {GetDate()} {GetType()}({GetLength()} min)- Distance:{_Distance} miles, Speed:{CalcSpeed()} MPH, Pace:{CalcPace()} min per mile");
    }
}