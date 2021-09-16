
//`![](ArrowUp)  Press Caps+C at the top of the file to add a copyright header.
// You can change settings used in this copyright in the
// CodeRush Options dialog, on the IDE | User Info page ![](Gear;crcommand:Options:User Info).

using System;
using System.Collections.Generic;
using System.Linq;

namespace CapsModifierTests
{
	public class CapsC
	{
		/* 
		 ![Enable Rich Comments to see embedded images](CapsC)

		 Use Caps+C to:
		
				* Add a Copyright header
				* Add missing Constructors
				* Switch/Case to Conditional
				* Conditional to Switch/Case
				* Declare a Class
				* Combine/Split Conditionals
				* Add method Contracts
				
			 
		 Examples follow in the source code below (and above).

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.
		
		*/
	}

	public class ContractTests
	{

		protected void Play(string file, TimeSpan duration)
		{//`![](ArrowDown) Press Caps+C to add a contract for this method.

		}
	}

	//`              ![](ArrowDown) Press Caps+C to add missing constructors.
	public class Descendant: BaseClass
	{
		
	}



	public enum Flavors
	{
		Vanilla,
		Chocolate,
		Strawberry
	}
	
	public static class Utils
	{
		static int numVanillaLikes;
		static int numChocolateLikes;
		static int numStrawberryLikes;
		static bool warpDriveDamaged;
		static int dilithiumCrystalCount;
		static bool weNeedMorePower;
		static bool cannotDoItCaptain;
		public static double GetTotal(IEnumerable<object> values)
		{
			double sum = 0;

			foreach (var item in values)
			{
				//`![](ArrowDown) Press Caps+C to convert this Switch statement into an if/then conditional.
				switch (item)
				{
					case int val:
						sum += val;
						break;
					case IEnumerable<object> sublist:
						sum += GetTotal(sublist);
						break;
					default:
						sum += 0.5;
						break;
				}
			}
			return sum;
		}

		public static void Like(Flavors flavor)
		{
			//`![](ArrowDown) Press Caps+C to convert this Conditional statement into a Switch/Case statement.
			if (flavor == Flavors.Chocolate)
			{
				numChocolateLikes++;
			}
			else if (flavor == Flavors.Strawberry)
			{
				numStrawberryLikes++;
			}
			else if (flavor == Flavors.Vanilla)
			{
				numVanillaLikes++;
			}
		}

		static void WorkWithCustomers()
		{
			//`                 ![](ArrowDown) Press Caps+C to declare a new class "RedShirt".
			var andrew = new RedShirt("Andrew", "Fuller");
			andrew.Age = 47;
			andrew.SaveToDB();
		}


		public static void SafeEngageWarpDrive()
		{
			//`![](ArrowDown) Press Caps+C to combine these conditionals:
			if (warpDriveDamaged)
				return;
			if (dilithiumCrystalCount == 0)
				return;
			if (weNeedMorePower && cannotDoItCaptain)
				return;
			EngageWarpDrive();
		}

		static void EngageWarpDrive()
		{

		}

		static TimeSpan fiveYears = TimeSpan.FromDays(365.25 * 5);




		static bool SatisfiesMission(Space space, World world, TimeSpan missionDuration, bool willInterfereWithNaturalAlienDevelopment = false)
		{
			//`                                               ![](ArrowDown) Press Caps+C on the logical operators to split these conditionals:
			if (space.SomeoneHasBeenHere || world.Explored || missionDuration > fiveYears || willInterfereWithNaturalAlienDevelopment)
				return false;

			return true;
		}

		static Utils()
		{
		}
	}

	public class Space
	{
		public bool SomeoneHasBeenHere { get; set; }
		public Space()
		{
			
		}
	}
	public class World
	{
		public bool Explored { get; set; }
		public World()
		{
			
		}
	}
}


