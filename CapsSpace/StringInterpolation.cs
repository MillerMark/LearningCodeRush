using System;
using System.Linq;

namespace CapsModifier
{
	public partial class StringInterpolation
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to convert to string interpolation: 

		public static string FoundRecord(int index)
		{
			if (index < 0 || index >= allRecords.Count)
				throw new ArgumentException("index parameter is out of range.");

			//`               ![](ArrowDown) Caps+Space to convert to string interpolation: 
			return "Found record #" + allRecords[index] + "!";
		}
		//`![](BtnMoreLikeThis;crcommand:OpenFile:StringInterpolation.cs) << StringInterpolation and more...
	}
}

