using System;

class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Perform(int duration)
    {
        Start(duration);

        string[] reflectionPrompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        for (int i = 0; i < duration; i++)
        {
            string reflectionPrompt = reflectionPrompts[i % reflectionPrompts.Length];
            Console.WriteLine(reflectionPrompt);
            DisplayAnimation("Thinking...   ");

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                DisplayAnimation("Reflecting...   ");
            }
        }

        End();
    }
}