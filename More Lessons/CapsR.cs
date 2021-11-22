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
		![Enable Rich Comments to see embedded images](CapsR;;;0.03,0.03)

		Use Caps+R to Reorder Parameters.
		 
		Examples follow in the source code below.

		Arrows (![](ArrowDown;;;0.008,0.008)) show caret position. 

		Move to where the arrow points before pressing the shortcut.

		*/

		// Use Caps+R to Reorder Parameters.
		// Use the **Tab** and **Arrow** keys to select and move parameters.
		// Enter accepts. Escape cancels.

		//`                      ![](ArrowDown;;;0.008,0.008) Caps+R to reorder these parameters
		internal void LotsOfParameters(string msg2, double Y, string msg1, double Z, double X)
		{

		}

		internal void CallingMethod()
		{
			// You can also Reorder Parameters from a *calling method*.

			//`                                  ![](ArrowDown;;;0.008,0.008) Caps+R to reorder these parameters
			LotsOfParameters("Message 2", 2, "Message 1", 3, 1);
		}
	}


	//`++Great Work!

	/* 
	You used Caps+R to Reorder Parameters.
	  

	![](NextLesson;crcommand:OpenFile:ShiftCapsSpace.cs;;0.04,0.04)  << Shift+Caps+Space for tuples, types, and more...

	*/
}
