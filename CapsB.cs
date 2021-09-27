using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsB
	{
		//`![Enable Rich Comments to see embedded images](CapsB)

		/*
		 Caps+B works with Braces ("{" and "}"), expression Bodies, and Booleans,
		 and it can Break apart (or line up) parameters...

		 Use Caps+B to:
		
				* add or remove Block delimiters - "{" and "}" in C#
				* convert a Boolean to an enum
				* Break apart (or line up) Arguments & Parameters (and Attributes in XAML)
				* use an expression Body (or expand an expression Body to a method/property)
			 
		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.
		*/

		bool started;
		
		public void Startup()
		{
			//`           ![](LookHere) Look here when you try the next one.
			if (GetState())
				Console.WriteLine("All good!");
		}

		//`         ![](ArrowDown) Press Caps+B to convert this boolean into an enum.
		internal bool GetState()
		{
			if (started)
				return true;
			else
				return false;
		}

		internal void CreateTestCustomers()
		{
			//` ![](ArrowDown) Press Caps+B to break these parameters onto multiple lines.
			AddCustomer("Mark", "Miller", Guid.NewGuid());



			//` ![](ArrowDown) Press Caps+B to line up these parameters onto a single line.
			AddCustomer("Rory", 
				null, 
				Guid.NewGuid());
		}



		//`      ![](ArrowDown) Press Caps+B to break apart or line up these parameters:
		void AddCustomer(string firstName, string lastName, Guid id)
		{
			Customer customer = new Customer();
			customer.FirstName = firstName;
			customer.LastName = lastName;
			customer.Id = id;
		}

	}

	//`++Great Work!

	/* 
	 You used Caps+B to:
	
	   * expand and collapse expression Bodies
	   * Break apart and line up arguments and parameters
	   * add or remove Block delimiters
	   * convert a Boolean to an enum

	 ![](NextLesson;crcommand:OpenFile:CapsC.cs)

	 */

}
