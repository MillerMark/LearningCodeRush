using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	public abstract partial class CombineSplitConditionals
	{

		//`![Enable Rich Comments to see embedded images](CapsSpace;;;0.03,0.03) Caps+Space to combine or split conditionals.

		public void SafeEngageWarpDrive()
		{	//`![](ArrowDown;;;0.008,0.008) Press Caps+Space to combine (or later split) these conditionals:
			if (warpDriveDamaged)
				return;
			if (dilithiumCrystalCount == 0)
				return;
			if (weNeedMorePower && weCannotDoItCaptain)
				return;


			//`++Pro Tip: Split Conditionals
			// You can split conditionals with Caps+Space on **boolean operators**
			// where it makes sense. For example, move to any "||" in the
			// **combined** expression above and then press Caps+Space.

			// Try it!

			EngageWarpDrive();
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:FlattenConditionals.cs;;0.04,0.04) << Flatten Conditionals and more...
}

