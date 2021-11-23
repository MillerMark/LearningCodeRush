using System;
using System.Linq;

namespace CapsModifier
{
	public class AddGetterSetter
	{
		//`![Enable Rich Comments to see embedded images](CapsInsert;;;0.03,0.03)

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
You used Caps+Insert to add new parameters, missing constructors, event triggers, and more.


![](NextLesson;crcommand:OpenFile:CapsDot.cs;;0.04,0.04)  << Caps+. to expand and collapse code formatting

*/


