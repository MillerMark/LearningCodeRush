using System;
using System.Linq;

namespace CapsModifierTests
{
	/* 
	   ![Enable Rich Comments to see embedded images](CapsPlusDelete)

	 Use Caps+Delete to remove redundant and unnecessary code. Usually available when the caret is at the start of the item to remove.

	 Use Caps+Delete to Remove:

	  * Discard Variables
	  * Redundant Block Delimiters
	  * Redundant Constructors
	  * Redundant Destructors
	  * Unused Locals
	  * Unused Parameters
	  * Unused Types

	 Examples are below:
	 */
	

	public class CapsDelete
	{
		// Caps+Delete for Remove Redundant Constructor:
		public CapsDelete()
		{
		}

		// Caps+Delete for Remove Redundant Destructor:
		~CapsDelete() { 
		}

		public void CallMethod()
		{
			GetMethodName(null, "Yo yo yo");
		}

		// Remove the unused parameter (available on the unused argument above or parameter below):

		string GetMethodName(ISymbol symbol, string unusedMessage)
		{
			// Remove the redundant type qualifier (available on the "CapsModifierTests")
			// Remove the discard variable (available on the "_")
			// Remove redundant block delimiters (available on either brace in the block above).

			if (symbol is CapsModifierTests.IMethodSymbol _)
			{
				return symbol.Name;
			}
			

			//! Remove redundant assignment??? 

			// Remove unused local:
			string varName = null;
			varName = "Yo";

			return null;
		}

		event EventHandler TextChanged;
		void HookEvents()
		{
			// Remove the redundant delegate creation (available on "new EventHandler"):
			TextChanged += new EventHandler(ProcessText);
		}

		void ProcessText(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}

	// Remove unused type:
	internal class UnusedType
	{
		public UnusedType()
		{

		}
	}
}


