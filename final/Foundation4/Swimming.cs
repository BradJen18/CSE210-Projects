using System.Runtime.Intrinsics.X86;

class Swimming : Activity
{
    private int _NumOfLaps;

    public int GetNumOfLaps()
    {
        return _NumOfLaps;
    }
    public void SetNumOfLaps(int laps)
    {
        _NumOfLaps = laps;
    }
    public override double CalcDistance()
    {
        double distance = (_NumOfLaps * 50) / 1000 * 0.62;
        return Math.Round(distance,2);
    }
    public override double CalcSpeed()
    {
        int length = GetLength();
        double speed = (CalcDistance()/length) * 60;
        return Math.Round(speed,2);
    }
    public override double CalcPace()
    {
        double pace = 60 / CalcSpeed();
        return Math.Round(pace,2);
    }
    public override void GetSummary()
    {
        Console.WriteLine($" - {GetDate()} {GetType()}({GetLength()} min)- Distance:{CalcDistance()} miles, Speed:{CalcSpeed()} MPH, Pace:{CalcPace()} min per mile");
    }
    public Swimming()
    {
        _NumOfLaps = 0;
    }
    public Swimming(string date, int length, string type, int laps) : base (date, length, type)
    {
        _NumOfLaps = laps;
    }
}