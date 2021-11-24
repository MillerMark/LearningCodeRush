using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

namespace CapsModifier
{
	public class Properties
	{
		/* 
		![](CapsP;crcommand:OpenFile:CapsP.cs;;0.03000,0.03000) declares Properties

		![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.04,0.04)  << Learn about the Target Picker.

		*/


		protected double GetCurrencyRate(Currency source)
		{
			// Press Caps+P to declare "LastSelected" as a property:
			//`   ![](ArrowDown;;;0.008,0.008)
			LastSelected = source;
			throw new NotImplementedException();
		}

	}

	//`++Great Work!

	/* 
	You used Caps+P to:
	
		* Promote to Generic Parameter
		* Promote to Parameter
		* Pull Members Up
		* Declare Parameter
		* Declare Partial Class Part
		* Declare Property
		* Declare Initialized Property

	![](NextLesson;crcommand:OpenFile:CapsQ.cs;;0.04,0.04)  >> Caps+Q for Constants...

	*/
}


