using Develop03;

class Program
{
    static string verse = @"
My fathers, having turned from their righteousness, and from the holy commandments which the Lord their God 
had given unto them, unto the worshiping of the gods of the heathen, utterly refused to hearken to my voice; 

For their hearts were set to do evil, and were wholly turned to the god of Elkenah, and the god of Libnah, 
and the god of Mahmackrah, and the god of Korash, and the god of Pharaoh, king of Egypt;";
    static string reference = "Abraham 1:5-6";

    static void Main(string[] args)
    {
        // Instantiate a Scripture with a verse and reference
        Scripture scripture = new Scripture(verse, new Reference(reference), 3);
        string input = "";

        do
        {
            // Clear the screen before displaying scripture
            Console.Clear();
            // Write out scripture and verse
            Console.Write(scripture.ToString());
            // Get user's input
            input = Console.ReadLine();
        }
        while (!input.ToUpper().Equals("QUIT") && !scripture.isFinished());
    }
}