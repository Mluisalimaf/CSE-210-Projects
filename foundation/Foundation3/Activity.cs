using System;

public class Activity
{
    protected int _duration;

    protected DateTime _date;

    public Activity(int duration, DateTime date)
    {
        _duration = duration;
        _date = date;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetVelocity()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_duration} min): " +
           $"Distance: {GetDistance():0.0} km, " +
           $"Speed: {GetVelocity():0.0} kph, " +
           $"Pace: {GetPace():0.00} min per km";
    }
}