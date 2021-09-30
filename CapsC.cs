
//`![](ArrowUp)  Press Caps+C at the top of the file to add a copyright header.
// You can change settings used in this copyright in the
// CodeRush Options dialog, on the IDE | User Info page ![](Gear;crcommand:Options:User Info).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace CapsModifier
{
	public class CapsC
	{
		//`![Enable Rich Comments to see embedded images](CapsC)

		/* 
		 Caps+C lets you add Copyrights, Constructors, Classes, and Contracts, and 
		 lets you work with Conditionals and switch/Case statements.

		 Use Caps+C to:
		
				* add a Copyright header
				* add missing Constructors
				* convert a Conditional to a switch/Case statement (and back)
				* declare a Class
				* Combine/split Conditionals
				* add method Contracts
				
			 
		 Examples follow in the source code below (and above).

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.
		
		*/
	}

	public class ContractTests
	{

		protected void Play(string playlist, string file, TimeSpan duration)
		{//`![](ArrowDown) Press Caps+C to add a contract for this method.
			
		}
	}

	//`              ![](ArrowDown) Press Caps+C to add missing constructors.
	public class Descendant: BaseClass
	{
		
	}



	public class Enterprise
	{
		static void WorkWithCustomers()
		{
			//`               Caps+C ![](ArrowDown) to declare a new class "RedShirt".
			RedShirt andrew = new RedShirt("Andrew", "Fuller");
			andrew.Age = 47;
			andrew.SaveToDB();
		}


		static TimeSpan fiveYears = TimeSpan.FromDays(365.25 * 5);




		static bool SatisfiesMission(Space space, World world, TimeSpan missionDuration, bool willInterfereWithNaturalAlienDevelopment = false)
		{
			//`                                               ![](ArrowDown) Press Caps+C on the logical operators to split these conditionals:
			if (space.SomeoneHasBeenHere || world.Explored || missionDuration > fiveYears || willInterfereWithNaturalAlienDevelopment)
				return false;

			return true;
		}
	}

	//`++Great Work!

	/* 
	 You used Caps+C to:
	
	   * add a Copyright header
		 * add missing Constructors
		 * convert a Conditional to a switch/Case statement (and back)
		 * declare a Class
		 * Combine and split Conditionals
		 * add method Contracts

	 ![](NextLesson;crcommand:OpenFile:CapsF.cs)

	 */
}


