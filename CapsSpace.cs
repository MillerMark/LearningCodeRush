using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace CapsModifier
{
	public abstract class CapsSpace
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
		    * Initializers
		    
		 And you can use Caps+Space to flatten conditionals, simplify 
		 expressions, add/remove block delimiters around/from child 
		 statements, convert procedures to functions, expand lambda 
		 functions, and more.


		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		*/


		const string STR_NullValue = "(null value)";
		string postalCode;
		string name;
		bool started;



		internal void BlockDelimeters()
		{
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
				//`![](ArrowDown) Press Caps+Space to add new block delimiters here.
				Console.WriteLine("It's Saturday!");

			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
			{
				Console.WriteLine("It's Saturday!");
			}
			//`![](ArrowUp) Press Caps+Space to remove these block delimiters.
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



		//`![](ArrowDown) Press Caps+Space to expand this expression body into a property body:
		public bool WeHaveIssues => !GetState();



		//`![](ArrowDown) Press Caps+Space to expand this expression body into a method body:
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

			//`![](ArrowDown) Caps+Space to expand (or compress) this local function: 
			int Fib(int n2)
			{
				return n2 < 2 ? n2 : Fib(n2 - 1) + Fib(n2 - 2);
			}
		}


		public void CreateTestCustomer1()
		{
			//`                  ![](ArrowDown) Caps+Space to Convert to an Initializer: 
			Customer andrew = new Customer();
			andrew.FirstName = "Andrew";
			andrew.LastName = "Fuller";
			andrew.Age = 48;
			andrew.Ready();
		}

		public void CreateTestCustomer2()
		{
			//`                  ![](ArrowDown) Caps+Space to Decompose this Initializer: 
			Customer jackson = new Customer() { FirstName = "Jackson", LastName = "Grand", Age = 35 };
			jackson.Ready();
		}


		//`                           ![](ArrowDown) Caps+Space to expand this lambda function: 
		Func<string, int> func = s => s == null ? 0 : s.Length;


		internal bool GetState() => started;



		public void AssignmentCompression(ref int a)
		{//`![](ArrowDown) Caps+Space to compress or expand these assignments: 
			a = a + 3;
			a = a * 3;
			a /= 3;
			a |= 2 * 2 * 2;
		}




		internal double GetCube(double value)
		{//`         ![](ArrowDown) Caps+Space to use Math.Pow instead.
			return value * value * value;
		}




		//`         ![](LookHere) Look here when you try the next one.
		internal void GetSquare(double value)
		{//`  ![](ArrowDown) Caps+Space to convert this procedure to a function.
			return Math.Pow(value, 2);
		}
	}




	//! IMessageSender is an interface...
	public interface IMessageSender
	{
		//`![](LookHere) Look here when you try the next one.
		void CreateCustomerLists(string key);
	}

	public class GreetingsSender : IMessageSender
	{
		public void CreateCustomerLists(string key)
		{
			List<Customer> customerList = new List<Customer>();
			customerLists.Add(key, customerList);

			//`  ![](ArrowDown)  Press Caps+Space to convert this proc to a function.
			return customerLists[key];
		}

		Dictionary<string, List<Customer>> customerLists = new Dictionary<string, List<Customer>>();
	}




	public abstract class Starship
	{
		static bool warpDriveDamaged;
		static int dilithiumCrystalCount;
		static bool weNeedMorePower;
		static bool weCannotDoItCaptain;



		public void SafeEngageWarpDrive()
		{//` ![](ArrowDown) Press Caps+Space to combine (and split) these conditionals:
			if (warpDriveDamaged)
				return;
			if (dilithiumCrystalCount == 0)
				return;
			if (weNeedMorePower && weCannotDoItCaptain)
				return;


			//`++Pro Tip: Split Conditionals
			// You can split conditionals with Caps+Space on boolean operators
			// where it makes sense. For example, move to any "||" in the
			// combined expression above and then press Caps+Space.

			// Try it!

			EngageWarpDrive();
		}


		public abstract void Start();
		public abstract void ReadData();
		public abstract void Draw();
		public abstract void DoMoreWork();
		public abstract void FinishDrawing();
		internal abstract void EngageWarpDrive();




		internal void NestedMethod1(bool okayToStart, bool okayToReadData, bool okayToDraw)
		{
			// Flatten Conditional can make a deeply nested method flatter.

			//`![](ArrowDown) Press Caps+Space to flatten this conditional.
			if (okayToStart)
			{
				Start();


				//`![](ArrowDown) Flatten this conditional too.
				if (okayToReadData)
				{
					ReadData();


					//`![](ArrowDown) And flatten this.
					if (okayToDraw)
					{
						Draw();
						DoMoreWork();
						FinishDrawing();
					}
				}
			}
		}

		//`++ Pro Tip: SmartNav
		// You can use Caps plus the arrow keys to navigate among sibling nodes
		// (like the if-statements in the method above).

		// You can alternate Caps+Space with Caps+Down to flatten a deeply nested
		// methods even faster.

		// Below, you can try it again. This time, press Caps+Down after you
		// flatten each conditional with Caps+Space.

		internal void NestedMethod2(bool okayToStart, bool okayToReadData, bool okayToDraw)
		{
			//`![](ArrowDown) Press Caps+Space to flatten (and then Caps+Down to move the caret).
			if (okayToStart)
			{
				Start();


				//`![](ArrowDown) Flatten this conditional too.
				if (okayToReadData)
				{
					ReadData();


					//`![](ArrowDown) And flatten this.
					if (okayToDraw)
					{
						Draw();
						DoMoreWork();
						FinishDrawing();
					}
				}
			}
		}

		static Dictionary<int, Customer> dictionary = new Dictionary<int, Customer>();

		private static string FoundRecord(int value)
		{
			//`         ![](ArrowDown) Caps+Space to convert to string interpolation: 
			return "Found record #" + value + "!";
		}


		public static void InitializeImplicitly(int? foo)
		{
			//`![](ArrowDown) Caps+Space to make these variable declarations implicit: 
			byte[] bar1 = dictionary[foo.Value].Id.ToByteArray();

			//`![](ArrowDown) 
			string bar2 = foo.HasValue ? FoundRecord(foo.Value) : "baz";

			//`![](ArrowDown) 
			Dictionary<int, Customer>.KeyCollection bar3 = dictionary.Keys;

			//`![](ArrowDown) 
			System.String bar4 = (new int[foo.Value * foo.Value, 5])[0, 0].ToString();
		}



		//`++ Pro Tip: SmartNav
		// Remember to use Caps+Down/Up to navigate among sibling nodes
		// (like the variable declarations in the method above).

		// You can alternate Caps+Space with Caps+Down to convert variable 
		// declarations even faster.




		public static void InitializeExplicitly(int? foo)
		{
			//`![](ArrowDown) Caps+Space to make explicit (and then Caps+Down to move the caret): 
			var bar1 = dictionary[foo.Value].Id.ToByteArray();


			//`![](ArrowDown) 
			var bar2 = foo.HasValue ? FoundRecord(foo.Value) : "baz";


			//`![](ArrowDown) 
			var bar3 = dictionary.Keys;


			//`![](ArrowDown) 
			var bar4 = new int[foo.Value * foo.Value, 5];
		}
	}


	//! Note: InterstellarRocket implements INotifyPropertyChanged!!!
	// Caps+Space can help you here, too (see below).
	public class InterstellarRocket: INotifyPropertyChanged
	{
		double fuelLevel;
		public event PropertyChangedEventHandler PropertyChanged;



		//`![](ArrowDown) Caps+Space adds change notification (in setter) to an existing property: 
		public double FuelLevel
		{
			get => fuelLevel;
			set => fuelLevel = value;
		}



		//`![](ArrowDown) Caps+Space converts to a property with a change notification: 
		public double PayloadTotalWeight
		{
			get; 
			set;
		}
	}

	//`++Great Work!
	/* 
	 Caps+Space is a powerful tool for compressing and expanding code. Use it to 
	 work with expression bodies, ternary or null coalescing expressions, block 
	 delimiters, conditionals, implicit/explicit variable declarations, and a 
	 host of other toggling features. 

	 You also got an introduction to Smart Nav (Caps + arrow keys). Good job!

 ![](NextLesson;crcommand:OpenFile:CapsDelete.cs)

 */
}

