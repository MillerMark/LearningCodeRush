using System;
using System.Linq;

namespace CapsModifier
{
	public partial class InlineTemp
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace;;;0.03,0.03) Caps+Space to inline temporary variables.

		public float CalculateDiscountedPrice(float price)
		{
			float percentage = GetCurrentDiscount();
			float fraction = percentage * 0.01f;

			//`                 ![](ArrowDown;;;0.008,0.008) Caps+Space to inline this temp (twice if you like): 
			return price - fraction * price;
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:TernaryExpressions.cs) << Ternary Expressions and more...
}

