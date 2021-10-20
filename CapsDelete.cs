using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsDelete
	{
		//`![Enable Rich Comments to see embedded images](CapsPlusDelete)

		/* 
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

		int count;
		public void Filler(int count)
		{
			this.count = count;
		}

		//`![](ArrowSW) Caps+Delete to remove the redundant constructor:
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
			GetSymbolName(null, "Yo yo yo");
		}

		// Caps+Delete to remove the unused parameter:
		//`                                              ![](ArrowDown)
		string GetSymbolName(ISymbol symbol, string unusedMessage)
		{
			// Caps+Delete to remove:
			//   * Redundant type qualifiers
			//   * Discard variables ("_")
			//   * Redundant block delimiters
			//`                  ![](ArrowDown)
			if (symbol is CapsModifier.IMethodSymbol _)
			{//`![](ArrowLeft)
				return symbol.Name;
			}


			// Caps+Delete to remove the unused local:
			//`        ![](ArrowDown)
			string varName = null;
			varName = "Yo";

			return null;
		}

		public static bool HasAssignment(SimpleNameSyntax identifier)
		{
			SyntaxNode assignment;
			
			// TODO: Remove this example if we don't fix our ability to trigger Discard Variable from Execute Refactoring.
			// Caps+Delete to discard the variable: ![](ArrowDown) 
			return identifier.HasAssignment(out assignment);
		}

		event EventHandler TextChanged;
		void HookEvents()
		{
			// Caps+Delete ![](ArrowDown) to remove the redundant delegate creation:
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

	//`++Great Work!

	/* 
	 You used Caps+Delete to remove unnecessary or unused code, including:
	
	   * Discard Variables
		 * Block Delimiters
		 * Constructors
		 * Destructors
		 * Locals
		 * Parameters
		 * Types

	 ![](NextLesson;crcommand:OpenFile:CapsInsert.cs)  << Caps+Insert to add new code...

	 */
}


