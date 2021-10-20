using System;
using System.Linq;

namespace CapsModifier
{
	public partial class ExpressionBodies
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace)  Caps+Space converts between normal and expression bodies.


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


		//`![](ArrowDown) Caps+Space to toggle again... 
		public bool AllGood => GetState();


		//`![](ArrowDown) Press Caps+Space to use an expression body for this method:
		internal bool AllStarted()
		{
			return started;
		}


		//`![](ArrowDown) Press Caps+Space to expand this expression body into a property body:
		public bool WeHaveIssues => !GetState();


		//`![](ArrowDown) Press Caps+Space to expand this expression body into a method body:
		internal bool GetStarted() => started;


		internal int Fibonacci(int n)
		{
			if (n < 0)
				throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than or equal to zero.");
			return Fib(n);

			//`![](ArrowDown) Caps+Space to expand (or compress) this local function: 
			int Fib(int n) => n < 2 ? n : Fib(n - 1) + Fib(n - 2);
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:Initializers.cs) << Initializers and more...
}

