using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	//`![Enable Rich Comments to see embedded images](CapsSpace;;;0.03,0.03) Caps+Space (on the return keyword) to convert a proc to a function.


	public class ConvertToFunction
	{
		//`           ![](LookHere;;;0.006,0.006) Look here (at the return type) when you try the next one.
		internal void GetSquareRoot(double value)
		{
			if (value < 0)
				throw new ArgumentException($"value must be positive");

			//`  ![](ArrowDown;;;0.008,0.008) Caps+Space to convert this procedure to a function.
			return Math.Pow(value, 0.5);
		}
	}



	//! ICustomerFactory is an interface...
	public interface ICustomerFactory
	{
		//`  ![](LookHere;;;0.006,0.006) Look here when you try the next one.
		void CreateCustomerLists(string key);
	}


	public partial class CustomerFactory : ICustomerFactory
	{
		//! CreateCustomerLists is from ICustomerFactory...
		public void CreateCustomerLists(string key)
		{
			List<Customer> customerList = new List<Customer>();
			customerLists.Add(key, customerList);

			//`  ![](ArrowDown;;;0.008,0.008)  Press Caps+Space to convert this proc to a function.
			return customerLists[key];
		}


		//`![](BtnMoreLikeThis;crcommand:OpenFile:DecomposeParameter.cs;;0.04,0.04) << Decompose Parameter and more...
	}
}

