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
		![](CapsM;;;0.04,0.04)

		Use Caps+M to:

			* Declare Method
			* Move Type to File
			* Move Initialization to Declaration
			* Move Declaration Near Reference
		 
		*/

		//`![](BtnTextFields;crcommand:OpenFile:TextFields.cs;;0.03,0.03)  << Learn about Text Fields.

		//`![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.03,0.03)  << Learn about the Target Picker.

		void Start(Dictionary<int, string> lookup, Action<Customer> callback)
		{
			//                  Caps+M ![](ArrowDown;;;0.008,0.008) to declare this method. 
			List<Analysis> results = Consume(lookup, Guid.NewGuid(), callback);
			if (results == null)
				return;
		}

		public static string GetFirstName(string name)
		{
			// Caps+M ![](ArrowDown;;;0.008,0.008) to move spaceIndex down near its first reference.
			int spaceIndex = name.IndexOf(' ');

			if (name == null)
				return "No name";

			if (name.StartsWith(">>"))
				return name.Substring(2);

			//  ![](LookHere;;;0.006,0.006) Look here when trying this one.
			if (spaceIndex < 0)
				return name;
			return name.Substring(0, spaceIndex);
		}



		string GetFull(Func<string> getFirst, Func<string> getLast)
		{
			string fullName;

			// ![](ArrowDown;;;0.008,0.008) Caps+M to move this initialization to its declaration (above)
			fullName = getFirst() + " " + getLast();

			return fullName;
		}
	}


	//       Caps+M ![](ArrowDown;;;0.008,0.008) to move this type to its own file. 
	public class Analysis
	{
		public string Message { get; set; }
		public object Data { get; set; }
		public bool Validated { get; set; }
		public Analysis()
		{
			// After moving this class to its own file, use Escape (or Alt+End) to get back.

			//` ![](BtnMarkers;crcommand:OpenFile:Markers.cs;;0.04,0.04)  << Learn about Markers.
		}
	}


	//`++Great Work!

	/*
		You used Caps+M to declare a Method, Move a type to a new file, Move an 
		initialization to its declaration, and Move a declaration near its first 
		reference.
	*/

	//`![](GotIt;vscommand:File.Close)
}


