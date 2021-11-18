using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsB
	{

		//`![Enable Rich Comments to see embedded images](CapsB;;;0.03,0.03)

		/*
		 Use Caps+B to convert a Boolean to an enum
			 
		 Examples follow in the source code below.

		 Arrows (![](ArrowDown;;;0.008,0.008)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.
		*/

		bool started;

		public void Startup()
		{
			//`           ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			if (GetState())
				Console.WriteLine("All good!");
		}

		//`         ![](ArrowDown;;;0.008,0.008) Press Caps+B to convert this boolean into an enum.
		internal bool GetState()
		{
			if (started)
				return true;
			else
				return false;
		}
	}

	//`++Great Work!

	/* 
	You used Caps+B to convert a Boolean to an enum, improving code 
	readability and flexibility (for example, instead of being limited
	to only two states, true or false, three or more states are possible
	with an enum).

	![](NextLesson;crcommand:OpenFile:CapsC.cs)  << Caps+C for Classes, Constructors, Contracts, and more...

	*/

}
