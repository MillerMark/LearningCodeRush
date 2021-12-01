using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	public class Locals
	{
		/*
		![](CapsL;crcommand:OpenFile:CapsL.cs;;0.03000,0.03000) declares Locals

		You can enter **any expression** onto an empty line, and then use 
		Caps+L to declare a new local variable for it.                       */

		public void Start(Dictionary<int, string> lookup, Action<Customer> callback)
		{
			//`![](ArrowDown;;;0.008,0.008) Caps+L to declare a new local for this expression: 
			Consume(lookup, Guid.NewGuid(), callback).FirstOrDefault();
		}

		List<Analysis> Consume(Dictionary<int, string> lookup, Guid newGuid, Action<Customer> callback)
		{
			throw new NotImplementedException();	
		}


		//`![](BtnCapsQ-ConstantsTrim;crcommand:OpenFile:Constants.cs;;0.04,0.04) << Next topic in the guided tour...

		// (or scroll down to end this lesson now)
	}


	//`++Great Work!
	/* 
	You used these Caps shortcuts to instantly declare code elements:

		![](BtnInstantDeclareTableShort;;;0.02,0.02) 	

	![](BtnMoreCapsShortcuts;crcommand:OpenFile:MoreCapsShortcuts.cs;;0.04,0.04)  << More Caps Shortcuts...   */
}
