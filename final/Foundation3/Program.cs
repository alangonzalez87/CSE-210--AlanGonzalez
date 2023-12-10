using System;


public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private string _address;

    public Event(string title, string description, DateTime date, TimeSpan time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GenerateStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}





// OutdoorGathering.cs
public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, string address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Outdoor Gathering\nWeather: {_weatherStatement}";
    }
}


class Program
{
    static void Main()
    {
        Lecture lectureEvent = new Lecture("AI Conference", "Exciting talks on AI", DateTime.Now, new TimeSpan(14, 0, 0), "123 Mardel plata", "Alan Gonzalez", 100);
        Reception receptionEvent = new Reception("Networking Night", "Casual networking event", DateTime.Now, new TimeSpan(18, 0, 0), "223 Buenos aires St", "Alan@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer BBQ", "Enjoy the sun and food", DateTime.Now, new TimeSpan(12, 0, 0), "345 Parque Primavessi", "Sunny and warm!");

        Console.WriteLine("Standard Details:\n");
        Console.WriteLine(lectureEvent.GenerateStandardDetails());
        Console.WriteLine("\n------------------------------------------------\n");

        Console.WriteLine("Full Details:\n");
        Console.WriteLine(receptionEvent.GenerateFullDetails());
        Console.WriteLine("\n------------------------------------------------\n");

        Console.WriteLine("Short Description:\n");
        Console.WriteLine(outdoorEvent.GenerateShortDescription());
    }
}
