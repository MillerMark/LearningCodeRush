using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsA
	{
		//`![Enable Rich Comments to see embedded images](CapsA)

		/* 

		 Use Caps+A to:
		
				* Declare an Auto-implemented Property
				* Name an Anonymous Type
			 
		 Examples follow in the source code below (and above). 

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.
		
		*/

		public bool Initialized { get; set; }

		//` ![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs)  << Learn more about the Target Picker.

		void Increment(int value)
		{
			// Press Caps+A to declare an auto-implemented property.
			// Position with the arrow keys. Enter accepts; Escape cancels.
			//`![](ArrowDown)
			MyProp = MyProp + value;
		}

		public void TestMethod()
		{
			//` ![](BtnMarkers;crcommand:OpenFile:Markers.cs)  << Learn about Markers.

			// Press Caps+A to Name an Anonymous Type.
			// CodeRush will take you to the new file and you 
			// can press Escape (or Alt+End) to get back.

			//`    ![](ArrowDown) (Caps+A on the variable name)
			var employee = new { ID = 1, Name = "Scotty", Department = "Engineering" };
			var employee1 = new { ID = 2, Name = "Spock", Department = "Science" };
			var employee2 = new { ID = 3, Name = "Kirk",  Department = "Command" };

			// You can change settings used in this refactoring in the CodeRush Options dialog,
			// on the Editor | C# | Code Actions | Name Anonymous Type Settings page ![](Gear;crcommand:Options:Editor\C#\Code Actions\Name Anonymous Type Settings).
		}



		//`++Great Work!

		/* 
     You used Caps+A to declare Auto-implemented properties and name Anonymous types!
		
		 ![](NextLesson;crcommand:OpenFile:CapsB.cs)  << Caps+B to convert booleans to enums...

     */
	}
}


