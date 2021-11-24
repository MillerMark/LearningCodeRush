using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
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
	}
}
