using System;

public class Cycling : Activity
{
    private double _speed; //in miles per hour alo

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        //(speed * minutes) /60
        return (_speed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // Pace =60 /speed
        return 60 / _speed;
    }
}