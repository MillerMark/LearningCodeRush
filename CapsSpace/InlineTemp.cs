using System;
using System.Linq;

namespace CapsModifier
{
	public partial class InlineTemp
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.03000,0.03000) to inline temporary variables.

		public float CalculateDiscountedPrice(float price)
		{
			float percentage = GetCurrentDiscount();
			float fraction = percentage * 0.01f;

			//`                 ![](ArrowDown;;;0.008,0.008) Caps+Space to inline this temp (twice if you like): 
			return price - fraction * price;
		}
	}

	//`![](BtnMoreCapsSpaceExamples;crcommand:OpenFile:MoreCapsSpace.cs;;0.03,0.03) << More Caps+Space examples...

	// (or scroll down to end this lesson now)
}

	//`++Great Work!

	/* 
	You used Caps+Space to compress/expand:

		* Implicit/Explicit Declarations
		* Expression Bodies
		* Initializers

	And you used Caps+Space to inline temporary variables.

	![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.04,0.04)  << Caps+Delete to remove code...   */

