using System;

public class Swimming : Activity
{
    private int _laps;
    private const double _lapDistanceInMiles = 50.0 / 1000 * 0.62;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)//inherited from base
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // swimming laps * 50 / 1000 * 0.62(to miles converter)
        return _laps * _lapDistanceInMiles;
    }

    public override double GetSpeed()
    {
        // the speed m per hour = (distance/minutes)* 60
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        // Pace(min per mile) =minutes/distance
        return GetMinutes() / GetDistance();
    }
}