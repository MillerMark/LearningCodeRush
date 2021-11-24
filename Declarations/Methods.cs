using System;
using System.Collections.Generic;

namespace CapsModifier
{
	public class Methods
	{
		/* 
			![](CapsM;crcommand:OpenFile:CapsM.cs;;0.03000,0.03000) declares Methods
		*/

		//`![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.04,0.04)  << Learn about the Target Picker.

		public void Start(Dictionary<int, string> lookup, Action<Customer> callback)
		{
			//                  Caps+M ![](ArrowDown;;;0.008,0.008) to declare this method.
			List<Analysis> results = GetAnalysis(lookup, Guid.NewGuid(), callback);
			if (results == null)
				return;
		}

		//`![](BtnMoreWithCapsM;crcommand:OpenFile:CapsM.cs;;0.03,0.03) << Caps+M can do even more!
	}

	//`![](BtnCapsP-Properties;crcommand:OpenFile:Properties.cs;;0.04,0.04) << Next topic in the guided tour...
}



//`![](NextLesson;crcommand:OpenFile:CapsDot.cs;;0.02,0.02)  << Skip ahead to the next lesson (Caps+.)...
