using System;
using System.Linq;

namespace CapsModifierTests
{
	public class CapsB
	{
		/* 
		 ![Enable Rich Comments to see embedded images](CapsB)

		 Use Caps+B to:
		
				* Add or remove Block delimiters - "{" and "}" in C#
				* Convert a Boolean to an Enum
				* Break apart (or line up) Arguments
				* Break apart (or line up) Attributes (in XAML)
				* Break apart (or line up) Parameters
				* Use an expression Body (or expand an expression body into a method or property)
			 
		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.
		*/

		bool started;
		
		public void Startup()
		{
			
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
				//`![](ArrowDown) Press Caps+B to add new block delimiters here.
				Console.WriteLine("It's Saturday!");



			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
			//`![](ArrowDown) Press Caps+B to remove these block delimiters.
			{
				Console.WriteLine("It's Saturday!");
			}


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



		//`![](ArrowDown) Press Caps+B to use an expression body for this property:
		public bool AllGood
		{
			get
			{
				return GetState();
			}
		}


		//`![](ArrowDown) Press Caps+B to use an expression body for this method:
		internal bool AllStarted()
		{
			return started;
		}



		//`![](ArrowDown) Press Caps+B to expand this expression body into a property:
		public bool NotGood => !GetState();


		//`![](ArrowDown) Press Caps+B to expand this expression body into a method:
		internal bool GetStarted() => started;

	}
}
