using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming (int duration, DateTime date, int laps)
    : base(duration, date)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // laps to km
    }

    public override double GetVelocity()
    {
        return (GetDistance() / (_duration/60)); 
    }

    public override double GetPace()
    {
        return _duration / GetDistance();
    }

}