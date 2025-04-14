using System;

public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        //(distance / minutes) *60
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        // Pace in min per miles
        return GetMinutes() / _distance;
    }
}