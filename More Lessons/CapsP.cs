using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

namespace CapsModifier
{
	public class CapsP
	{
		/* 
		![Enable Rich Comments to see embedded images](CapsP;;;0.03,0.03)

		Use Caps+P to:
		
			* Promote to Generic Parameter
			* Promote to Parameter
			* Pull Members Up
			* Declare Parameter
			* Declare Partial Class Part
			* Declare Property (auto-implemented)
			* Declare Property (with default body)
			* Declare Property with Initializer
		 
		Examples follow in the source code below.

		Arrows (![](ArrowDown;;;0.008,0.008)) show caret position. 

		Move to where the arrow points before pressing the shortcut.

		And when declaring initialized properties, use the Target Picker
		to specify where to generate the property. 
		
		![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.04,0.04)  << Learn about the Target Picker.

		*/



		public CapsP()
		{
			//`       ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			SayHello();
		}

		public void SayHello()
		{
			// Press Caps+P to Promote userName to a parameter:
			//`        ![](ArrowDown;;;0.008,0.008)
			string userName = "Mark";
			Console.WriteLine($"Greetings, {userName}!");
		}



		// Press Caps+P to Promote "Tool" to a generic parameter:
		//`![](ArrowDown;;;0.008,0.008)
		public Tool GetTool(string id)
		{
			return null;
		}
	}


	public class DeclaringInitializedProperties
	{
		// Sometimes you need to assign a parameter to a property that
		// doesn't exist yet.

		// Use Caps+P to declare a property initialized to the parameter value.

		//`                       ![](ArrowDown;;;0.008,0.008) Caps+P
		public void Start(Guid sessionId)
		{
		}

		//`++Pro Tip: Initialized Properties
		// CodeRush invokes the rename refactoring on new initialized
		// properties. If you like the suggested name you can press Enter
		// (or Escape). To get back to where you started, just collect the
		// marker CodeRush dropped where you started.

		//` ![](BtnMarkers;crcommand:OpenFile:Markers.cs;;0.04,0.04)  << Learn about Markers.

		// So if you need to declare several initialized properties in
		// a row, just press repeat this sequence:
		//
		//		Caps+P
		//		Pick your Target location
		//    Rename the property (or press Enter/Escape to accept the given name)
		//    Collect the marker to get back.

		//` ![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.04,0.04)  << Learn about the Target Picker.

		// Try declaring initialized properties for each of these parameters!

		//`                           ![](ArrowDown;;;0.008,0.008) Caps+P
		void SetCoordinates(double x, double y, double z)
		{
			
		}
	}


	public class Tool : BaseTool
	{
		bool engaging;

		// Use Caps+P to Pull this Engage() member up to the parent class (BaseTool).
		//` ![](ArrowDown;;;0.008,0.008)
		public void Engage()
		{
			engaging = true;
		}



		public static double ConvertToUSD(double amount)
		{
			// Press Caps+P to declare "source" as a parameter.
			//`                                  ![](ArrowDown;;;0.008,0.008)
			return amount / GetCurrencyRate(source);
		}

		protected static double GetCurrencyRate(Currency source)
		{
			// Press Caps+P to declare "LastSelected" as a property:
			//`   ![](ArrowDown;;;0.008,0.008)
			LastSelected = source;
			throw new NotImplementedException();
		}
	}

	// Press Caps+P to create a partial class part:
	//`   ![](ArrowDown;;;0.008,0.008)
	public class MyUtils
	{
		
		
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


