using System;

namespace CapsModifier
{
	public class CapsSlash
	{

		//`![](CapsSlash;;;0.04,0.04)

		/*
		
		Caps+/ expands and collapses code formatting.

		Use Caps+/ to:
		
			* Break apart (or line up) Arguments & Parameters (and Attributes in XAML)
			* Collapse/expand property accessors
		*/

		string postalCode;
		string city;
		string address;

		internal void CreateTestCustomers()
		{
			//` ![](ArrowDown;;;0.008,0.008) Press Caps+/ to break these parameters onto multiple lines.
			AddCustomer("Mark", "Miller", Guid.NewGuid());



			//` ![](ArrowDown;;;0.008,0.008) Press Caps+/ to line up these parameters onto a single line.
			AddCustomer("Rory",
				null,
				Guid.NewGuid());
		}

		//`                  ![](ArrowDown;;;0.008,0.008) Press Caps+/ to break apart or line up these parameters:
		void AddCustomer(string firstName, string lastName, Guid id)
		{
			Customer customer = new Customer();
			customer.FirstName = firstName;
			customer.LastName = lastName;
			customer.Id = id;
		}

		string name;

		public string Name
		{   //`![](ArrowDown;;;0.008,0.008) Press Caps+/ to collapse this getter:
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
			}//` ![](ArrowSW;;;0.008,0.008) Press Caps+/ to collapse this setter:
			set
			{
				address = value;
			}
		}


		public string City
		{   //`![](ArrowSW;;;0.008,0.008) Press Caps+/ to expand this getter:
			get { return city; }
			set { city = value; }
		}

		
		public string PostalCode
		{
			get => postalCode;
			//`![](ArrowDown;;;0.008,0.008) Press Caps+/ to expand this setter:
			set => postalCode = value;
		}
	}

	//`++Great Work!
	/*
	You used Caps+/ to:
	
		* Expand and collapse property getters, property setters, and expression bodies
		* Break apart and line-up arguments and parameters
	*/

	//`![](GotIt;vscommand:File.Close)
}
