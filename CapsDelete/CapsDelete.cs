using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsDelete
	{

		//`![Enable Rich Comments to see embedded images](CapsPlusDelete;;;0.03,0.03)

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

		 Arrows (![](ArrowDown;;;0.008,0.008)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.


			* Remove Type Qualifier - 986
			* Remove All Type Qualifiers - 955
			* Unused Member - 452
			* Redundant Block Delimiters - 403
			* Redundant All Redundant Block Delimiters - 215
			* Unused Parameters - 311
			* Discard Variables - 0
			* Redundant Constructors - 0
			* Redundant Destructors - 0
			* Unused Locals - 0
			* Unused Types - 0



	 */

		int count;
		public void Filler(int count)
		{
			this.count = count;
		}

		//`![](ArrowSW;;;0.008,0.008) Caps+Delete to remove the redundant constructor:
		public CapsDelete()
		{
		}



		// Caps+Delete to remove the redundant destructor:
		//`   ![](ArrowDown;;;0.008,0.008)
		~CapsDelete() { 
		}


		// Caps+Delete to remove the unused member:
		//`     ![](ArrowDown;;;0.008,0.008)
		void Button1_Clicked(object sender, EventArgs ea)
		{
			if (sender == null || ea == null)
				return;
		}

		public void CallMethod()
		{
			//`                     ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			GetSymbolName(null, "Yo yo yo");
		}

		// Caps+Delete to remove the unused parameter:
		//`                                              ![](ArrowDown;;;0.008,0.008)
		string GetSymbolName(ISymbol symbol, string unusedMessage)
		{
			// Caps+Delete to remove:
			//   * Redundant type qualifiers
			//   * Redundant block delimiters
			//`                  ![](ArrowDown;;;0.008,0.008)
			if (symbol is CapsModifier.IMethodSymbol _)
			{//`![](ArrowLeft;;;0.008,0.008)
				return symbol.Name;
			}


			// Caps+Delete to remove the unused local:
			//`        ![](ArrowDown;;;0.008,0.008)
			string varName = null;
			varName = "Yo";

			return null;
		}

		public static bool HasAssignment(SimpleNameSyntax identifier)
		{
			SyntaxNode assignment;
			
			// Caps+Delete to discard the unused variable: ![](ArrowDown;;;0.008,0.008) 
			return identifier.HasAssignment(out assignment);
		}

		event EventHandler TextChanged;
		void HookEvents()
		{
			// Caps+Delete ![](ArrowDown;;;0.008,0.008) to remove the redundant delegate creation:
			TextChanged += new EventHandler(ProcessText);
		}

		void ProcessText(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}

	// Caps+Delete to remove the unused type:
	//`                ![](ArrowDown;;;0.008,0.008)
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

	![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.04,0.04)  << Caps+Insert to add new code...

	*/
}


