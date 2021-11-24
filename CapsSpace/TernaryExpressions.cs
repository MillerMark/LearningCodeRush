using System;
using System.Linq;

namespace CapsModifier
{
	public partial class TernaryExpressions
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.03000,0.03000) to compress conditionals into ternary expressions.


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

	//`![](BtnMoreLikeThis;crcommand:OpenFile:CombineSplitConditionals.cs;;0.04,0.04) << Combine & Split Conditionals and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.02,0.02)  << Skip ahead to the next lesson...
