using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsA
	{

		//`![Enable Rich Comments to see embedded images](CapsA;;;0.03,0.03)

		/* 

		Use Caps+A to:
		
			* Declare Auto-implemented Properties
			* Name Anonymous Types
			* Convert properties with backing fields into Auto-implemented properties

		Examples follow in the source code below (and above). 

		Arrows (![](ArrowDown;;;0.008,0.008)) show caret position. 

		Move to where the arrow points before pressing the shortcut.
		
		*/

		public bool Initialized { get; set; }

		//` ![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.04,0.04)  << Learn more about the Target Picker.

		void Increment(int value)
		{
			// Press Caps+A to declare an auto-implemented property.
			// Position with the arrow keys. Enter accepts; Escape cancels.
			//`![](ArrowDown;;;0.008,0.008)
			MyProp = MyProp + value;
		}

		public void TestMethod()
		{
			//` ![](BtnMarkers;crcommand:OpenFile:Markers.cs;;0.04,0.04)  << Learn about Markers.

			// Press Caps+A to Name an Anonymous Type.
			// CodeRush will take you to the new file and you 
			// can press Escape (or Alt+End) to get back.

			//`    ![](ArrowDown;;;0.008,0.008) (Caps+A on the variable name)
			var employee = new { ID = 1, Name = "Scotty", Department = "Engineering" };
			var employee1 = new { ID = 2, Name = "Spock", Department = "Science" };
			var employee2 = new { ID = 3, Name = "Kirk",  Department = "Command" };

			// You can change settings used in this refactoring in the CodeRush Options dialog,
			// on the Editor | C# | Code Actions | Name Anonymous Type Settings page ![](Gear;crcommand:Options:Editor\C#\Code Actions\Name Anonymous Type Settings;;0.01,0.01).
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

		//`++Great Work!

		/* 
		 You used Caps+A to declare Auto-implemented properties and name Anonymous types!

			![](NextLesson;crcommand:OpenFile:CapsB.cs;;0.04,0.04)  << Caps+B to convert booleans to enums...

		 */
	}
}


