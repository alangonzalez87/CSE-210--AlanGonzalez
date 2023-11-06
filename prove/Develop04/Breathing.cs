using System;


class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public void Perform(int duration)
    {
        Start(duration);
        string[] animation = { "Breathe in...   ", "Breathe out...  " };

        for (int i = 0; i < duration; i++)
        {
            DisplayAnimation(animation[i % 2]);
        }

        End();
    }
}