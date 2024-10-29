using System;

public class Running : Activity
{
    private double _distance;

    public Running (int duration, DateTime date, double distance) 
    : base(duration, date)
    {
        _distance = distance;
        Console.WriteLine("Running activity created.");
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetVelocity()
    {
        return (_distance / _duration) * 60.0; 
    }

    public override double GetPace()
    {
        return (double)_duration / _distance;
    }

}