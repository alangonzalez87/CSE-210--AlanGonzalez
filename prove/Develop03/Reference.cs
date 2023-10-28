using System.Text;

namespace Develop03;

// Reference class keeps track of a scripture reference, including references that span multiple verses.
public class Reference
{
	private string reference;

	// Sets reference
	public Reference(string reference) => this.reference = reference;

	// Returns reference
	public override string ToString() => reference;
}