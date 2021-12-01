using System;

namespace CapsModifier
{
	public class AutoImplementedProperties
	{
		//`![](CapsA;crcommand:OpenFile:CapsA.cs;;0.03000,0.03000) declares Auto-implemented properties

		public void Increment(int value)
		{//`    ![](ArrowDown;;;0.008,0.008) Caps+A to declare an auto-implemented property.
			TotalCount += value;


			//` ![](ArrowDown;;;0.008,0.008) Caps+A to declare an auto-implemented property.
			LastChange = DateTime.Now;
		}

		//`![](BtnMoreWithCapsA;crcommand:OpenFile:CapsA.cs;;0.03,0.03) << Caps+A can do even more!
	}

	//`![](BtnCapsC-ClassesTrim;crcommand:OpenFile:Classes.cs;;0.04,0.04) << Next topic in the guided tour...
}



//`![](NextLesson;crcommand:OpenFile:MoreCapsShortcuts.cs;;0.04,0.04)  << Skip ahead to the next lesson (More Caps Shortcuts)...
