using System;
using System.Linq;

namespace CapsModifier
{
	public class AutoImplementedProperties
	{
		//`![](CapsA;crcommand:OpenFile:CapsA.cs;;0.03000,0.03000) declares Auto-implemented properties

		//` ![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.04,0.04)  << Learn more about the Target Picker.

		public void Increment(int value)
		{//`    ![](ArrowDown;;;0.008,0.008) Caps+A to declare an auto-implemented property.
			TotalCount += value;


			//` ![](ArrowDown;;;0.008,0.008) Caps+A to declare an auto-implemented property.
			LastChange = DateTime.Now;
		}
	}

	// ![](BtnMoreLikeThis;;;0.04,0.04)
}


