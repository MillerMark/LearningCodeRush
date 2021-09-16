using System;
using System.Linq;

namespace CapsModifierTests
{
	public class CapsDelete
	{
		/* 
	   ![Enable Rich Comments to see embedded images](CapsPlusDelete)

		 Use Caps+Delete to remove redundant and unnecessary code, including:

			* Discard Variables
			* Redundant Block Delimiters
			* Redundant Constructors
			* Redundant Destructors
			* Unused Locals
			* Unused Parameters
			* Unused Types

		 Examples are below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

	 */



		// Caps+Delete to remove the redundant constructor:
		//`   ![](ArrowDown)
		public CapsDelete()
		{
		}



		// Caps+Delete to remove the redundant destructor:
		//`   ![](ArrowDown)
		~CapsDelete() { 
		}



		public void CallMethod()
		{
			//`                     ![](LookHere) Look here when you try the next one.
			GetMethodName(null, "Yo yo yo");
		}

		// Caps+Delete to remove the unused parameter:
		//`                                              ![](ArrowDown)
		string GetMethodName(ISymbol symbol, string unusedMessage)
		{
			// Caps+Delete to remove:
			//   * Redundant type qualifiers
			//   * Discard variables ("_")
			//   * Redundant block delimiters
			//`                  ![](ArrowDown)
			if (symbol is CapsModifierTests.IMethodSymbol _)
			{//`![](ArrowLeft)
				return symbol.Name;
			}


			// Caps+Delete to remove the unused local:
			//`        ![](ArrowDown)
			string varName = null;
			varName = "Yo";

			return null;
		}

		event EventHandler TextChanged;
		void HookEvents()
		{
			// Caps+Delete to remove the redundant delegate creation:
			//`                     ![](ArrowDown)
			TextChanged += new EventHandler(ProcessText);
		}

		void ProcessText(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}

	// Caps+Delete to remove the unused type:
	//`                ![](ArrowDown)
	internal class UnusedType
	{
		public UnusedType()
		{

		}
	}
}


