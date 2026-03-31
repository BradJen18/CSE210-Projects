using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

class Activity
{
    private string _Date;
    private int _Length;
    private string _Type;

    public string GetDate()
    {
        return _Date;
    }
    public void SetDate(string date)
    {
        _Date = date;
    }
    public int GetLength()
    {
        return _Length;
    }
    public void SetLength(int length)
    {
        _Length = length;
    }
    public string Gettype()
    {
        return _Type;
    }
    public void SetType(string type)
    {
        _Type = type;
    }
    public Activity()
    {
        _Date = "";
        _Length = 0;
        _Type = "Activity";
    }
    public Activity(string date, int length, string type)
    {
        _Date = date;
        _Length = length;
        _Type = type;
    }

    public virtual double CalcDistance()
    {
        double distance = 5 * 50 / (1000 *0.62);
        return distance;
    }
    public virtual double CalcSpeed()
    {
        double speed = (6/30) * 60;
        return speed;
    }
    public virtual double CalcPace()
    {
        double pace = 60/7.5;
        return pace;
    }
    public virtual void GetSummary()
    {
        Console.WriteLine($" - {_Date} {_Type}({_Length} min)- Distance:{CalcDistance()} miles, Speed:{CalcSpeed()} MPH, Pace:{CalcPace()} min per mile");
    }

}