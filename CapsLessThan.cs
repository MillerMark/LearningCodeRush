using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsLessThan
	{

		//`![Enable Rich Comments to see embedded images](CapsLessThan)

		/* 

		 Caps+< (Caps key plus the less-than key) is a collapsing tool for your code...

		 Use Caps+< to collapse:
		
				* Accessors
				* Getters & Setters
				* Local Functions
				* Methods & Properties
			
		 You can also use Caps+< to compress to:

		    * Null Coalescing Operations
		    * Ternary Expressions
		    * Shorter Assignments
		    
		 And you can use Caps+< to Combine Conditionals and Simplify Expressions.


		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		*/

		//! Note: If you are using a non-US keyboard, this binding may be different.
		// Check the Shortcuts options page (in the Code\Actions\Special folder) for a 
		// binding to **Caps** plus the **comma** (Caps+,) and change the binding if needed.


		// You can click the gear icon (![](Gear;crcommand:Options:IDE\Shortcuts)) to jump to the IDE | Shortcuts options page.
		// (then open Code\Actions\Special to see the bindings)


		int a;
		public int A
		{
			get
			{
				return a;
			}
			set
			{
				a = value;
			}
		}

	}

	//`++Great Work!
	/* 
	 Caps+H adds a copyright header (and so does Caps+C, when the 
	 caret is at the top of the file). So when you need a copyright 
	 header, you can think of the first letter of either word and 
	 use it along with the Caps key. Easy.

 ![](NextLesson;crcommand:OpenFile:CapsP.cs)

 */
}

