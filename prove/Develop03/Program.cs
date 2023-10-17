using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a scripture reference (e.g., 'John 3:16'):");
        string referenceInput = Console.ReadLine();

        // Create a Scripture object based on user input
        Scripture scripture = new Scripture(referenceInput);

        Console.Clear();
        scripture.DisplayWithHiddenWords();

        while (!scripture.AllWordsHidden)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
            Console.Clear();
            scripture.DisplayWithHiddenWords();
        }
    }
}

class Scripture
{
    private string reference;
    private List<Word> words;
    private Random random = new Random();
    private int hiddenWordsCount = 0;

    public bool AllWordsHidden => hiddenWordsCount == words.Count;

    public Scripture(string reference)
    {
        this.reference = reference;
        this.words = LoadWordsFromDatabase(); // Load words from your data source
    }

    private List<Word> LoadWordsFromDatabase()
    {
        // Implement this method to load words based on the scripture reference.
        // For simplicity, we'll use dummy data in this example.
        return new List<Word>
        {
            new Word("For"),
            new Word("God"),
            new Word("so"),
            new Word("loved"),
            new Word("the"),
            new Word("world"),
            new Word("that"),
            new Word("He"),
            new Word("gave"),
            new Word("His"),
            new Word("only"),
            new Word("begotten"),
            new Word("Son,"),
            new Word("that"),
            new Word("whoever"),
            new Word("believes"),
            new Word("in"),
            new Word("Him"),
            new Word("should"),
            new Word("not"),
            new Word("perish"),
            new Word("but"),
            new Word("have"),
            new Word("eternal"),
            new Word("life.")
        };
    }

    public void HideRandomWord()
    {
        int randomIndex = random.Next(words.Count);

        if (!words[randomIndex].IsHidden)
        {
            words[randomIndex].Hide();
            hiddenWordsCount++;
        }
    }

    public void DisplayWithHiddenWords()
    {
        Console.WriteLine(reference);
        StringBuilder displayText = new StringBuilder();

        foreach (var word in words)
        {
            displayText.Append(word.IsHidden ? "____ " : word.Text + " ");
        }

        Console.WriteLine(displayText.ToString());
    }
}

class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
    }

    public void Hide()
    {
        IsHidden = true;
    }
}
