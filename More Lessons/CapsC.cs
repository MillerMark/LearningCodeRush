
//`![](ArrowNW;;;0.008,0.008)  Press Caps+C at the top of the file to add a copyright header.

using System;
using System.Collections.Generic;
// Copyright settings are taken from the User Info options page: ![](Gear;crcommand:Options:User Info;;0.01,0.01)

namespace CapsModifier
{
	public class CapsC
	{

		//`![](CapsC;;;0.03,0.03)

		/*
		Caps+C lets you add Copyrights, Constructors, Classes, and Contracts, and 
		lets you work with Conditionals and switch/Case statements.

		Use Caps+C to:
		
				* add a Copyright header
				* add missing Constructors
				* convert a Conditional to a switch/Case statement (and back)
				* declare a Class
				* add method Contracts
		
		*/
	}

	public class ContractTests
	{

		protected void Play(string playlist, string file, TimeSpan duration)
		{//`![](ArrowDown;;;0.008,0.008) Press Caps+C to add a contract for this method.
			
		}
	}

	//`              ![](ArrowDown;;;0.008,0.008) Press Caps+C to add missing constructors.
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

		public static double GetTotal(IEnumerable<object> values)
		{
			double sum = 0;

			foreach (var item in values)
			{
				//`![](ArrowDown;;;0.008,0.008) Press Caps+C to convert this Switch statement into an if/then conditional.
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
			//`![](ArrowDown;;;0.008,0.008) Press Caps+C to convert this Conditional statement into a Switch/Case statement.
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
	}


	public class Enterprise
	{
		static void WorkWithCustomers()
		{
			//`               Caps+C ![](ArrowDown;;;0.008,0.008) to declare a new class "RedShirt".
			RedShirt andrew = new RedShirt("Andrew", "Fuller");
			andrew.Age = 47;
			andrew.SaveToDB();
		}
	}

	//`++Great Work!

	/*
	You used Caps+C to:
	
		* add a Copyright header
		* add missing Constructors
		* convert a Conditional to a switch/Case statement (and back)
		* declare a Class
		* add method Contracts                                                   */

	//`![](GotIt;vscommand:File.Close;;0.04,0.04)
}
