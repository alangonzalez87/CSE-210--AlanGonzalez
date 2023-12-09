using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, string address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override  string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}
