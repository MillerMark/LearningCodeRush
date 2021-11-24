using System;
using System.Linq;

namespace CapsModifier
{
	public abstract partial class FlattenConditionals
	{

		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.03000,0.03000) to flatten conditionals.

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

	//`![](BtnMoreLikeThis;crcommand:OpenFile:SimplifyExpressions.cs;;0.04,0.04) << Simplify Expressions and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.02,0.02)  << Skip ahead to the next lesson (Caps+Delete)...
