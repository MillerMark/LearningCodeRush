using System;
using System.Linq;

namespace CapsModifier
{
	public partial class TernaryExpressions
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace;;;0.03,0.03) Caps+Space to compress conditionals into ternary expressions.


		public string CheckName(string name)
		{
			string result;

			//`![](ArrowSW;;;0.008,0.008) Caps+Space to compress this conditional into a ternary expression: 
			if (name != null)
				result = name;
			else
				result = STR_NullValue;

			return result;
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:CombineSplitConditionals.cs) << Combine & Split Conditionals and more...
}

