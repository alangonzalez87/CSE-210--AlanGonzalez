using System;

public class DiaryEntry
{
    public string Message { get; set; }
    public string Date { get; set; }

    public DiaryEntry(string message)
    {
        Message = message;
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public override string ToString()
    {
        return $"{Date} | {Message}";
    }
}
