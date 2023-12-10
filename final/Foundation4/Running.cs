using System;

using System.Collections.Generic;


// Clase derivada para correr
public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _durationMinutes * 60;
    }

    public override double GetPace()
    {
        return _durationMinutes / _distance;
    }
}