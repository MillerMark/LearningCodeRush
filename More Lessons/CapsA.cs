using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsA
	{
		//`![](CapsA;;;0.03,0.03)

		/*
		Use Caps+A to:
		
			* Declare Auto-implemented Properties
			* Convert properties with backing fields into Auto-properties    */

		public bool Initialized { get; set; }

		//` ![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.03,0.03)  << Learn more about the Target Picker.

		void Increment(int value)
		{
			// Press Caps+A to declare an auto-implemented property.
			// Position with the arrow keys. Enter accepts; Escape cancels.
			//`![](ArrowDown;;;0.008,0.008)
			MyProp = MyProp + value;
		}


		string phoneNumber;
		//`![](ArrowDown;;;0.008,0.008) Caps+A to make a property (with backing field) auto-implemented: 
		public string PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
			set
			{
				phoneNumber = value;
			}
		}
	}
	//`++Great Work!
	/* 
	You used Caps+A to declare Auto-implemented properties and name  
	Anonymous types!                                                         */

	//`![](GotIt;vscommand:File.Close;;0.04,0.04)
}


