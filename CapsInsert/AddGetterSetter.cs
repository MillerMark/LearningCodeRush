using System;
using System.Linq;

namespace CapsModifier
{
	public class AddGetterSetter
	{
		//`![](CapsInsert;crcommand:OpenFile:CapsInsert.cs;;0.03,0.03) to add a setter or a getter.

		//`                         ![](ArrowDown;;;0.008,0.008) Caps+Insert to add a setter.
		public int NeedsSetter { get; }

		int needsGetter;
		bool started;
		public int NeedsGetter
		{   //`![](ArrowDown;;;0.008,0.008) Caps+Insert to add a getter.
			set => needsGetter = value;
		}
	}
}

//`++Great Work!

/* 
	You used Caps+Insert to add missing constructors, new parameters, 
	members to interfaces, event triggers, and more.

	![](NextLesson;crcommand:OpenFile:Declarations.cs;;0.04,0.04)  << Shortcuts for instant declarations...

*/



