using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	//`![](ShiftCapsF)
	/*

	 Use Shift+Caps+F to: 

			* Rename Type to Match File
			* ForEach to Linq


	 Examples follow in the source code below.

	 Arrows (![](ArrowDown)) show caret position. 

	 Move to where the arrow points before pressing the shortcut.

	*/

	//`                        ![](ArrowDown) Press Shift+Caps+F to rename this class to match the file name.
	public abstract class ThisClassNeedsRenaming
	{


		public static int overflowCount;


		public static int ProcessItems(List<int> items)
		{
			var result = 10;


			//`![](ArrowDown) Press Shift+Caps+F to convert this foreach into a Linq statement.
			foreach (int item in items)
			{
				result *= item;
				result -= item * 2;
			}

			if (result > 100)
				overflowCount++;
			return result;
		}

	}

	


	//`++Great Work!
	/* 
	 You used Shift+Caps+F to rename a class to match its file name and to 
	 convert foreach statements into Linq statements. 

 ![](NextLesson;crcommand:OpenFile:CapsG.cs)

 */

}