using System;
using System.Linq;

namespace CapsModifier
{
	public partial class NullCoalescing
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to compress to (or expand) null coalescing operations.

		public string CheckPostalCode(string postalCode)
		{
			if (!IsValidPostalCode(postalCode))
				throw new ArgumentException("Invalid Postal Code");

			//`![](ArrowDown) Caps+Space to expand this null coalescing operation: 
			return postalCode ?? STR_NullValue;
		}


		public string CheckAddress(string address)
		{
			CheckPostalCode(GetPostalCode(address));

			//`![](ArrowDown) Caps+Space to compress to a null coalescing operation: 
			return address != null ? address : STR_NullValue;
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:DecomposeParameter.cs) << Decompose Parameter and more...
}

