using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

namespace CapsModifier
{
	public class CapsR
	{
		/* 
		 ![Enable Rich Comments to see embedded images](CapsR)

		 Use Caps+R to Reorder Parameters.
			 
		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		*/

		// Use Caps+R to Reorder Parameters.
		// Use the **Tab** and **Arrow** keys to select and move parameters.
		// Enter accepts. Escape cancels.

		//`                      ![](ArrowDown) Caps+R to reorder these parameters
		internal void LotsOfParameters(string msg2, double Y, string msg1, double Z, double X)
		{

		}

		internal void CallingMethod()
		{
			// You can also Reorder Parameters from a *calling method*.

			//`                                  ![](ArrowDown) Caps+R to reorder these parameters
			LotsOfParameters("Message 2", 2, "Message 1", 3, 1);
		}
	}


	//`++Great Work!

	/* 
	 You used Caps+R to Reorder Parameters.
	   

	 ![](NextLesson;crcommand:OpenFile:ShiftCapsSpace.cs)  << Shift+Caps+Space for tuples, types, and more...

	 */
}


