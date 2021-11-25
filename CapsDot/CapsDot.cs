using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsDot
	{

		//`![](CapsDot;;;0.04,0.04)

		/*
		
		Caps+. expands and collapses code formatting.

		Use Caps+. to:
		
			* Break apart (or line up) Arguments & Parameters (and Attributes in XAML)
			* Collapse/expand property accessors, local functions, methods, and properties

			 
		Examples follow in the source code below.

		Arrows (![](ArrowDown;;;0.008,0.008)) show caret position. 

		Move to where the arrow points before pressing the shortcut.

		*/

		string postalCode;
		string city;
		string address;
		bool started;

		internal void CreateTestCustomers()
		{
			//` ![](ArrowDown;;;0.008,0.008) Press Caps+. to break these parameters onto multiple lines.
			AddCustomer("Mark", "Miller", Guid.NewGuid());



			//` ![](ArrowDown;;;0.008,0.008) Press Caps+. to line up these parameters onto a single line.
			AddCustomer("Rory",
				null,
				Guid.NewGuid());
		}



		//`                  ![](ArrowDown;;;0.008,0.008) Press Caps+. to break apart or line up these parameters:
		void AddCustomer(string firstName, string lastName, Guid id)
		{
			Customer customer = new Customer();
			customer.FirstName = firstName;
			customer.LastName = lastName;
			customer.Id = id;
		}


		string name;

		public string Name
		{   //`![](ArrowDown;;;0.008,0.008) Press Caps+. to collapse this getter:
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}


		public string Address
		{
			get
			{
				return address;
			}//` ![](ArrowSW;;;0.008,0.008) Press Caps+. to collapse this setter:
			set
			{
				address = value;
			}
		}


		public string City
		{   //`![](ArrowSW;;;0.008,0.008) Press Caps+. to expand this getter:
			get { return city; }
			set { city = value; }
		}

		
		public string PostalCode
		{
			get => postalCode;
			//`![](ArrowDown;;;0.008,0.008) Press Caps+. to expand this setter:
			set => postalCode = value;
		}
	}

	//`++Great Work!

	/* 
	You used Caps+. to:
	
		* Expand and collapse property getters, property setters, and expression bodies
		* Break apart and line-up arguments and parameters


	![](NextLesson;crcommand:OpenFile:CapsA.cs;;0.04,0.04)  << Caps+A for Auto-implemented properties and more

	*/
}
