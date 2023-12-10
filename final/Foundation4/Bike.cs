using System;

using System.Collections.Generic;


// Clase derivada para bicicletas estáticas
public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * _durationMinutes / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}