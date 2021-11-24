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

	//`![](BtnMoreLikeThis;crcommand:OpenFile:TernaryExpressions.cs;;0.04,0.04) << Ternary Expressions and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.02,0.02)  << Skip ahead to the next lesson...
