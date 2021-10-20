using System.Collections.Generic;

namespace CapsModifier
{
	public partial class ImplicitExplicit
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace)  Caps+Space converts between implicit & explicit declarations.


		public static void InitializeImplicitly(int? foo)
		{
			//`![](ArrowDown) Caps+Space to make these variable declarations implicit: 
			byte[] bar1 = dictionary[foo.Value].Id.ToByteArray();

			//`![](ArrowDown) 
			string bar2 = foo.HasValue ? FoundRecord(foo.Value) : "baz";

			//`![](ArrowDown) 
			Dictionary<int, Customer>.KeyCollection bar3 = dictionary.Keys;
		}


		//`![](SmartNav;crcommand:OpenFile:SmartNav.cs)  << Learn about SmartNav...

		//++ Pro Tip
		// You can alternate Caps+Space with Caps+Down (SmartNav) to convert 
		// variable declarations even faster. Try it in the code below.


		public static void InitializeExplicitly(int? foo)
		{
			//`![](ArrowDown) Caps+Space to make explicit (and then Caps+Down to move the caret): 
			var bar1 = dictionary[foo.Value].Id.ToByteArray();


			//`![](ArrowDown) 
			var bar2 = foo.HasValue ? FoundRecord(foo.Value) : "baz";


			//`![](ArrowDown) 
			var bar3 = dictionary.Keys;


			//`![](ArrowDown) 
			var bar4 = new int[foo.Value * foo.Value, 5];
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:ExpressionBodies.cs) << Expression Bodies and more...
}
