using System;
using System.Linq;

namespace CapsModifier
{
	public abstract partial class FlattenConditionals
	{

		//`![Enable Rich Comments to see embedded images](CapsSpace;;;0.03,0.03) Caps+Space to flatten conditionals.

		internal void NestedMethod1(bool okayToStart, bool okayToReadData, bool okayToDraw)
		{
			// Flatten Conditional can make deeply nested methods flatter.

			//`![](ArrowSW;;;0.008,0.008) Press Caps+Space to flatten this conditional.
			if (okayToStart)
			{
				Start();


				//`![](ArrowSW;;;0.008,0.008) Flatten this conditional too.
				if (okayToReadData)
				{
					ReadData();


					//`![](ArrowSW;;;0.008,0.008) And flatten this.
					if (okayToDraw)
					{
						Draw();
						DoMoreWork();
						FinishDrawing();
					}
				}
			}
		}


		//`![](SmartNav;crcommand:OpenFile:SmartNav.cs)  << Learn about SmartNav...


		//`++ Pro Tip: SmartNav
		// You can use SmartNav to make flattening methods like these even faster.

		// Below, try it again, but this time press Caps+Down after you flatten each
		// conditional with Caps+Space.


		internal void NestedMethod2(bool okayToStart, bool okayToReadData, bool okayToDraw)
		{
			//`![](ArrowSW;;;0.008,0.008) Press Caps+Space to flatten (and then Caps+Down to move to the next conditional).
			if (okayToStart)
			{
				Start();


				//`![](ArrowSW;;;0.008,0.008) Flatten this conditional too.
				if (okayToReadData)
				{
					ReadData();


					//`![](ArrowSW;;;0.008,0.008) And flatten this.
					if (okayToDraw)
					{
						Draw();
						DoMoreWork();
						FinishDrawing();
					}
				}
			}
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:SimplifyExpressions.cs) << Simplify Expressions and more...
}

