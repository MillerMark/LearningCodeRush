using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;

namespace CapsModifier
{
	public class CapsM
	{
		/* 
		![Enable Rich Comments to see embedded images](CapsM)

		Use Caps+M to:

			* Declare Method
			* Move Type to File
			* Move Initialization to Declaration
			* Move Declaration Near Reference
		 
		Examples follow in the source code below.

		Arrows (![](ArrowDown)) show caret position. 

		Move to where the arrow points before pressing the shortcut.

		*/

		//`![](BtnTextFields;crcommand:OpenFile:TextFields.cs)  << Learn about Text Fields.

		//`![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs)  << Learn about the Target Picker.

		//`![](BtnMarkers;crcommand:OpenFile:Markers.cs)  << Learn about Markers.


		void Start(Dictionary<int, string> lookup, Action<Customer> callback)
		{
			//                  Caps+M ![](ArrowDown) to declare this method. 
			List<Analysis> results = Consume(lookup, Guid.NewGuid(), callback);
			if (results == null)
				return;
		}

		public static string GetFirstName(string name)
		{
			// Caps+M ![](ArrowDown) to move spaceIndex down near it's first reference.
			int spaceIndex = name.IndexOf(' ');

			if (name == null)
				return "No name";

			if (name.StartsWith(">>"))
				return name.Substring(2);

			//  ![](LookHere) Look here when trying this one.
			if (spaceIndex < 0)
				return name;
			return name.Substring(0, spaceIndex);
		}



		string GetFull(Func<string> getFirst, Func<string> getLast)
		{
			string fullName;

			// ![](ArrowDown) Caps+M to move this initialization its declaration (above)
			fullName = getFirst() + " " + getLast();

			return fullName;
		}
	}



	//       Caps+M ![](ArrowDown) to move this type to its own file. 
	public class Analysis
	{
		public string Message { get; set; }
		public object Data { get; set; }
		public bool Validated { get; set; }
		public Analysis()
		{
			// After moving this class to its own file, use Escape (or Alt+End) to get back.

			//` ![](BtnMarkers;crcommand:OpenFile:Markers.cs)  << Learn about Markers.
		}
	}


	//`++Great Work!

	/* 
	You used Caps+M to declare a Method, Move a type to a new file, Move an 
	initialization to its declaration, and Move a declaration near its first 
	reference.

	![](NextLesson;crcommand:OpenFile:CapsP.cs)  << Caps+P for Parameters, Partial classes, and Properties...

	 */
}


