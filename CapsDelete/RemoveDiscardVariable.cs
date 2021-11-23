using CapsModifier;

public class RemoveDiscardVariable
{
	public static bool HasAssignment(SimpleNameSyntax identifier)
	{
		//` ![](LookHere;;;0.008,0.008) Look here when you try the next one.
		SyntaxNode assignment;
		//`                       Caps+Delete ![](ArrowDown;;;0.008,0.008) to discard the unused variable: 
		return identifier.HasAssignment(out assignment);
	}
}

//`++Great Work!

/* 
You used Caps+Delete to remove unnecessary or unused code, including:

	* Type Qualifiers
	* All Type Qualifiers (with Shift+Caps+Delete)
	* Unused Members
	* All Redundant Block Delimiters
	* Unused Parameters
	* Redundant Delegate Creation
	* Unused Locals
	* Unused Types
	* Redundant Constructors
	* Redundant Destructors
	* Discard Variables

![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.04,0.04)  << Caps+Insert to add new code...

*/


