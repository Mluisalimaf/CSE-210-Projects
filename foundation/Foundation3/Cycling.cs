using System;

public class Cycling : Activity
{
    private double _velocity;

    public Cycling(int duration, DateTime date, double velocity)
    : base(duration, date)
    {
        _velocity = velocity;
    }

    public override double GetDistance() // distance = velocity * time (in hours)
    {
        return _velocity * (_duration / 60.0);
    }

    public override double GetVelocity()
    {
        return _velocity; 
    }

    public override double GetPace()
    {
        return 60.0 / _velocity; //pace = 60 / speed
    }


}