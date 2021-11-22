using System;
using System.Linq;

namespace CapsModifier
{
	public partial class StringInterpolation
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace;;;0.03,0.03) Caps+Space to convert to string interpolation: 

		public static string FoundRecord(int index)
		{
			if (index < 0 || index >= allRecords.Count)
				throw new ArgumentException("index parameter is out of range.");

			//`               ![](ArrowDown;;;0.008,0.008) Caps+Space to convert to string interpolation: 
			return "Found record #" + allRecords[index] + "!";
		}
		//`![](BtnMoreLikeThis;crcommand:OpenFile:StringInterpolation.cs;;0.04,0.04) << StringInterpolation and more...
	}
}

