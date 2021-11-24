using System;
using System.Linq;

namespace CapsModifier
{
	public class BlockDelimiters
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.03000,0.03000) to add or remove block delimiters ("{" and "}")
		//`                   around single-statement child nodes. 

		public void BlockDelimeters()
		{
			if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
				//`![](ArrowSW;;;0.008,0.008) Press Caps+Space (at start of line) to add new block delimiters here.
				Console.WriteLine("Have a great weekend!");


			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
			{
				Console.WriteLine("It's Saturday!");
			}
			//` ![](ArrowNW;;;0.008,0.008) Press Caps+Space to remove these block delimiters.
			//`    This also works when the caret is on the leading "{").
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:NullCoalescing.cs;;0.04,0.04) << Null coalescing operations and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.02,0.02)  << Skip ahead to the next lesson...
