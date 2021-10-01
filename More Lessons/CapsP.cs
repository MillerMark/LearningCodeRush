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
		 ![Enable Rich Comments to see embedded images](CapsP)

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

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		 And when declaring a initialized properties, CodeRush will let 
		 you select the location for the property using the target picker. 
		
		 It looks like this:

		![](TargetPicker)

		 Just use the up and down arrow keys, followed by the Enter key
		 to select the location for the generated code. 

		 After using the target picker, you can press Escape (or Alt+End)
		 to get back.

		*/



		public CapsP()
		{
			//`       ![](LookHere) Look here when you try the next one.
			SayHello();
		}

		public void SayHello()
		{
			// Press Caps+P to Promote userName to a parameter:
			//`        ![](ArrowDown)
			string userName = "Mark";
			Console.WriteLine($"Greetings, {userName}!");
		}



		// Press Caps+P to Promote "Tool" to a generic parameter:
		//`![](ArrowDown)
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

		//`                       ![](ArrowDown) Caps+P
		public void Start(Guid sessionId)
		{
		}

		//`++Pro Tip: Initialized Properties
		// CodeRush drops a marker for you on the parameters before
		// declaring the initialized property. CodeRush also gives you 
		// a chance to rename the property. If you like the name you can 
		// press Enter or Escape. Then to get back to the parameter marker
		// you can press Escape again (or Alt+Home).

		// So if you need to declare several initialized properties in
		// a row, just press repeat this sequence:
		//
		//		Caps+P
		//		Select the target location (up/down + Enter keys)
		//    Rename the property (or press Escape to accept the given name)
		//    Press Escape (or Alt+Home) to get back.

		// Try declaring initialized properties for each of these parameters!

		//`                           ![](ArrowDown) Caps+P
		void SetCoordinates(double x, double y, double z)
		{
			
		}
	}



	public class Tool : BaseTool
	{
		bool engaging;

		// Use Caps+P to Pull this Engage() member up to the parent class (BaseTool).
		//` ![](ArrowDown)
		public void Engage()
		{
			engaging = true;
		}



		public static double ConvertToUSD(double amount)
		{
			// Press Caps+P to declare "source" as a parameter.
			//`                                  ![](ArrowDown)
			return amount / GetCurrencyRate(source);
		}

		protected static double GetCurrencyRate(Currency source)
		{
			// Press Caps+P to declare "LastSelected" as a property:
			//`   ![](ArrowDown)
			LastSelected = source;
			throw new NotImplementedException();
		}

		public enum Currency
		{
			USD,
			EUR,
			GBR
		}
	}

	// Press Caps+P to create a partial class part:
	//`   ![](ArrowDown)
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
	   

	 ![](NextLesson;crcommand:OpenFile:CapsQ.cs)

	 */
}


