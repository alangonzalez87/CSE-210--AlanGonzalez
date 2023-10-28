using System.ComponentModel.Design.Serialization;
using System.Text.RegularExpressions;

namespace Develop03;

// Keeps track of an individual word in a scripture. When hidden, it returns underscores the same length of the 
// word.
public class Word
{
	private string word;
	private bool isVisible = true;

	public Word(string word)
	{
		this.word = word;
	}

	public void hide() { isVisible = false; }

	public bool getIsVisible() => isVisible;

	// Returns the word if visible, underscores of the same length if hidden.
	public override string ToString()
	{
		return isVisible ? word : Regex.Replace(word, "[a-zA-Z]", "_");
	}
}