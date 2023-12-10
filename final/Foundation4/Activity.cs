using System;

using System.Collections.Generic;


// Clase base Activity
public class Activity
{
    protected DateTime _date;
    protected int _durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_durationMinutes} min): " +
               $"distance {GetDistance()} miles, speed {GetSpeed()} mph, pace: {GetPace()} min per mile";
    }
}
