using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;

namespace CapsModifier
{
	public class CapsL
	{
		/* 
		![Enable Rich Comments to see embedded images](CapsL;;;0.03,0.03)

		Use Caps+L to declare a Local variable.

		You can enter any expression onto an empty line, and then use 
		Caps+L to declare a new local variable for it.
		 
		Examples follow in the source code below.

		Arrows (![](ArrowDown;;;0.008,0.008)) show caret position. 

		Move to where the arrow points before pressing the shortcut.

		*/



		void Start(Dictionary<int, string> lookup, Action<Customer> callback)
		{
			//`![](ArrowDown;;;0.008,0.008) Caps+L to declare a new local. 
			Consume(lookup, Guid.NewGuid(), callback).FirstOrDefault();
		}

		List<Analysis> Consume(Dictionary<int, string> lookup, Guid newGuid, Action<Customer> callback)
		{
			throw new NotImplementedException();
		}

	}



	//`++Great Work!

	/* 
	You used Caps+L to declare a new local based on an expression on the line.

	![](NextLesson;crcommand:OpenFile:CapsM.cs;;0.04,0.04)  << Caps+M to declare Methods and for Moving...

	*/
}


