using System;
using System.Linq;

namespace CapsModifier
{
	public partial class NullCoalescing
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.03000,0.03000) to compress to (or expand) null coalescing operations.

		public string CheckPostalCode(string postalCode)
		{
			if (!IsValidPostalCode(postalCode))
				throw new ArgumentException("Invalid Postal Code");

			//`![](ArrowDown;;;0.008,0.008) Caps+Space to expand this null coalescing operation: 
			return postalCode ?? STR_NullValue;
		}


		public string CheckAddress(string address)
		{
			CheckPostalCode(GetPostalCode(address));

			//`![](ArrowDown;;;0.008,0.008) Caps+Space to compress to a null coalescing operation: 
			return address != null ? address : STR_NullValue;
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:InlineLambda.cs;;0.04,0.04) << Inline Lambda and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.02,0.02)  << Skip ahead to the next lesson (Caps+Delete)...
