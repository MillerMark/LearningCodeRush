using System;
using System.Linq;

namespace CapsModifier
{
	public class BlockDelimiters
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to add or remove block delimiters ("{" and "}")
		//`                   around single-statement child nodes. 

		public void BlockDelimeters()
		{
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
				//`![](ArrowSW) Press Caps+Space (at start of line) to add new block delimiters here.
				Console.WriteLine("It's Saturday!");

			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
			{
				Console.WriteLine("It's Saturday!");
			}
			//`![](ArrowUp) Press Caps+Space to remove these block delimiters (this also works 
			//`   when the caret is on the leading "{").
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:NullCoalescing.cs) << Null coalescing operations and more...
}

