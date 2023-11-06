class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Activities Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Exit");
            Console.Write("Select an activity (1/2/3): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                BreathingActivity activity = new BreathingActivity();
                activity.Perform(duration);
            }
            else if (choice == "2")
            {
                Console.Write("Enter the duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                ReflectionActivity activity = new ReflectionActivity();
                activity.Perform(duration);
            }
            else if (choice == "3")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.");
            }
        }
    }
}
