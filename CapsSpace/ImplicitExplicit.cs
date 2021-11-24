using System.Collections.Generic;

namespace CapsModifier
{
	public partial class ImplicitExplicit
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.03000,0.03000) converts between implicit & explicit declarations.


		public static void InitializeImplicitly(int? foo)
		{
			//`![](ArrowDown;;;0.008,0.008) Caps+Space to make these variable declarations implicit: 
			byte[] bar1 = dictionary[foo.Value].Id.ToByteArray();

			//`![](ArrowDown;;;0.008,0.008) 
			string bar2 = foo.HasValue ? FoundRecord(foo.Value) : "baz";

			//`![](ArrowDown;;;0.008,0.008) 
			Dictionary<int, Customer>.KeyCollection bar3 = dictionary.Keys;
		}


		//`![](SmartNav;crcommand:OpenFile:SmartNav.cs;;0.04,0.04)  << Learn about SmartNav...

		//++ Pro Tip
		// You can alternate Caps+Space with Caps+Down (SmartNav) to convert 
		// variable declarations even faster. Try it in the code below.


		public static void InitializeExplicitly(int? foo)
		{
			//`![](ArrowDown;;;0.008,0.008) Caps+Space to make explicit (and then Caps+Down to move the caret): 
			var bar1 = dictionary[foo.Value].Id.ToByteArray();


			//`![](ArrowDown;;;0.008,0.008) 
			var bar2 = foo.HasValue ? FoundRecord(foo.Value) : "baz";


			//`![](ArrowDown;;;0.008,0.008) 
			var bar3 = dictionary.Keys;


			//`![](ArrowDown;;;0.008,0.008) 
			var bar4 = new int[foo.Value * foo.Value, 5];
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:ExpressionBodies.cs;;0.04,0.04) << Expression Bodies and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.02,0.02)  << Skip ahead to the next lesson...
