using System;
using System.Threading;

class MindfulnessActivity
{
    protected string _name;
    protected string _description;

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void DisplayAnimation(string animation)
    {
        foreach (char c in animation)
        {
            Console.Write(c);
            Thread.Sleep(100);
            Console.Write("\b");
        }
    }

    public void Start(int duration)
    {
        Console.WriteLine($"{_name} Activity:");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {duration} seconds\n");
        DisplayAnimation("Prepare to begin...   ");
    }

    public void End()
    {
        DisplayAnimation("You have completed the activity.   \nGood job!\n\n");
    }
}