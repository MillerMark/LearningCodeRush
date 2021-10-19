using System;
using System.Linq;

namespace CapsModifier
{
	public partial class SimplifyExpressions
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to simplify overly complex expressions.

		public void ComplexExpression(bool six, bool bravo, bool halfDozen)
		{
			//`![](ArrowSW) Caps+Space to simplify this expression: 
			if (((six || (!bravo && (!(!six)))) || (halfDozen || !!halfDozen)))
				return;

			if (bravo)
				StartFanfare();
		}

		//`![](BtnMoreLikeThis;crcommand:OpenFile:BlockDelimiters.cs) << Block Delimiters and more...
	}
}

