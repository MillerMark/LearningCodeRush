using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	public class CapsSpace
	{

		//`![Enable Rich Comments to see embedded images](CapsSpace)

		/* 
		 Caps+Space is a toggling/conversion tool for your code.

		 Use Caps+Space to compress to (or expand from):

		    * Expression Bodies
		    * Implicit/Explicit Declarations
		    * Ternary Expressions
		    * Null Coalescing Operations
		    * Shorter Assignments
		    
		 And you can use Caps+Space to Split or Combine Conditionals, 
		 Simplify Expressions, and add/remove block delimiters around/from 
		 child statements.


		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		*/


		const string STR_NullValue = "(null value)";
		string postalCode;
		string name;
		bool started;



		void BlockDelimeters()
		{
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
				//`![](ArrowDown) Press Caps+Space to add new block delimiters here.
				Console.WriteLine("It's Saturday!");

			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
			{
				Console.WriteLine("It's Saturday!");
			}//`![](ArrowUp) Press Caps+Space to remove these block delimiters.
		}


		public string Name
		{
			//`![](ArrowDown) Caps+Space to toggle between accessor and expression bodies. 
			get
			{
				return name;
			}

			//`![](ArrowDown) Caps+Space to toggle between accessor and expression bodies.
			set => name = value;
		}


		//`![](ArrowDown) Caps+Space to toggle... 
		public bool AllGood
		{
			get
			{
				return GetState();
			}
		}


		//`![](ArrowDown) Press Caps+Space to use an expression body for this method:
		internal bool AllStarted()
		{
			return started;
		}



		//`![](ArrowDown) Press Caps+Space to expand this expression body into a property:
		public bool WeHaveIssues => !GetState();


		//`![](ArrowDown) Press Caps+Space to expand this expression body into a method:
		internal bool GetStarted() => started;


		public string CheckName(string name)
		{
			//`![](ArrowDown) Caps+Space to compress to a ternary expression: 
			if (name != null)
				return name;
			else
				return STR_NullValue;
		}


		public string CheckPostalCode(string postalCode)
		{
			//`![](ArrowDown) Caps+Space to expand this null coalescing operation: 
			return postalCode ?? STR_NullValue;
		}


		public string CheckAddress(string address)
		{
			//`![](ArrowDown) Caps+Space to expand or compress (your choice): 
			return address != null ? address : STR_NullValue;
		}


		internal int Fibonacci(int n)
		{
			if (n < 0)
				throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than or equal to zero.");
			return Fib(n);

			//`![](ArrowDown) Caps+Space to expand or compress this local function: 
			int Fib(int n2)
			{
				return n2 < 2 ? n2 : Fib(n2 - 1) + Fib(n2 - 2);
			}
		}



		//`                           ![](ArrowDown) Caps+Space to expand this lambda function: 
		Func<string, int> func = s => s == null ? 0 : s.Length;




		private static int? Foo;
		internal bool GetState() => started;
		static Dictionary<int, Customer> dictionary = new Dictionary<int, Customer>();



		static void Initialize()
		{
			//`![](ArrowDown) Caps+Space to convert between implicit and explicit declarations: 
			var bar1 = Foo.HasValue ? FoundRecord(Foo.Value) : "baz";

			//`![](ArrowDown) 
			int[,] bar2 = new int[Foo.Value * Foo.Value, 5];

			//`![](ArrowDown) 
			var bar3 = dictionary.Keys;

			//`![](ArrowDown) 
			var bar4 = dictionary[Foo.Value].Id.ToByteArray();
		}



		private static string FoundRecord(int value)
		{
			//`         ![](ArrowDown) Caps+Space to convert to string interpolation: 
			return "Found record #" + value + "!";
		}


		public void AssignmentCompression(ref int a)
		{//`![](ArrowDown) Caps+Space to compress or expand these assignments: 
			a = a + 3;
			a = a * 3;
			a /= 3;
			a |= 2 * 2 * 2;
		}


		static bool warpDriveDamaged;
		static int dilithiumCrystalCount;
		static bool weNeedMorePower;
		static bool cannotDoItCaptain;



		public static void SafeEngageWarpDrive()
		{//` ![](ArrowDown) Press Caps+Space to combine (and split) these conditionals:
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
	}

	//`++Great Work!
	/* 
	 Caps+Space is a great tool for compressing and expanding code. Use it to 
	 work with expression bodies, ternary or null coalescing expressions, block 
	 delimiters, conditionals, and implicit/explicit variable declarations. 

 ![](NextLesson;crcommand:OpenFile:CapsDelete.cs)

 */
}

