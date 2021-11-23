using System;

namespace CapsModifier
{
	public partial class RemoveUnusedParameter
	{
		//`![](CapsPlusDelete;;;0.03,0.03) removes unused parameters.

		public void CallMethod()
		{	//`                         ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			GetSymbolName(null, "Yo yo yo", DateTime.Now);
		}

		//`                                Caps+Delete ![](ArrowDown;;;0.008,0.008) to remove the unused parameter:
		string GetSymbolName(ISymbol symbol, string unusedMessage, DateTime requestTime)
		{
			prioritizeNextTask = (DateTime.Now - requestTime).TotalSeconds > 5;

			if (symbol is IMethodSymbol _)
				return symbol.Name;

			return null;
		}
	}

	// ![](BtnMoreCapsDeleteShortcuts;crcommand:OpenFile:MoreCapsDelete.cs;;0.04,0.04) << More ways to use Caps+Delete...

	// (or scroll down to end this lesson now)
}


//`++Great Work!

/* 
You used Caps+Delete to remove unnecessary or unused code, including:

	* Type Qualifiers
	* All Type Qualifiers (with Shift+Caps+Delete)
	* Unused Members
	* All Redundant Block Delimiters
	* Unused Parameters

![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.04,0.04)  << Caps+Insert to add new code...

*/


