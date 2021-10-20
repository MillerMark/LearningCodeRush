using System;
using System.Linq;

namespace CapsModifier
{
	public class MathDotPow
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to convert repeated multiplications into a Math.Pow call.

		public double GetCube(double value)
		{
			if (value < 0)
				throw new ArgumentException($"{value} is negative!");

			//`       ![](ArrowDown) Caps+Space to use Math.Pow instead.
			return value * value * value;
		}
	}


	//`++Great Work!
	/* 
	 Caps+Space is a powerful tool for compressing and expanding code. Use it to 
	 work with expression bodies, ternary or null coalescing expressions, block 
	 delimiters, conditionals, implicit/explicit variable declarations, and a 
	 host of other code-toggling features.

	 You also got an introduction to Smart Nav (Caps + arrow keys). Good job!

		![](NextLesson;crcommand:OpenFile:CapsDelete.cs)

 */
}
