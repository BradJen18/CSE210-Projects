using System.ComponentModel.DataAnnotations;

class Cycling : Activity
{
    private double _Speed;

    public double GetSpeed()
    {
        return _Speed;
    }
    public void SetSpeed(double speed)
    {
        _Speed = speed;
    }
    public override double CalcDistance()
    {
        int length = GetLength();
        double distance = (_Speed/60) * length;
        return distance;
    }
    public override double CalcPace()
    {
        double pace = 60/_Speed;
        return pace;
    }
    public override void GetSummary()
    {
        Console.WriteLine($" - {GetDate()} {GetType()}({GetLength()} min)- Distance:{CalcDistance()} miles, Speed:{_Speed} MPH, Pace:{CalcPace()} min per mile");
    }
    public Cycling()
    {
        _Speed = 0;
    }
    public Cycling(string date, int length, string type, double speed) : base (date, length, type)
    {
        _Speed = speed;
    }

}