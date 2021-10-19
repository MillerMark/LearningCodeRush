using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.IO;

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
	public class ExpandLambda
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to expand lambda functions.

		//`                Caps+Space ![](ArrowDown) on the "=>" to expand this lambda function: 
		Func<string, int> func = s => s == null ? 0 : s.Length;
	}

	//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space 

	/* 
	 Caps+Space is a toggling/conversion tool for your code.

	 Use Caps+Space to compress to (or expand from):

			* Implicit/Explicit Declarations
			* Expression Bodies
			* Ternary Expressions
			* Null Coalescing Operations
			* Shorter Assignments
			* Initializers

	 And you can use Caps+Space to flatten conditionals, inline 
	 temporary variables, simplify expressions, add/remove block 
	 delimiters around/from child statements, convert procedures 
	 to functions, expand lambda functions, and more.

	 Examples:

		![](BtnImplicitExplicit;crcommand:OpenFile:ImplicitExplicit.cs)

		![](BtnExpressionBodies;crcommand:OpenFile:ExpressionBodies.cs)

		![](BtnInitializers;crcommand:OpenFile:Initializers.cs)

		![](BtnInlineTemp;crcommand:OpenFile:InlineTemp.cs)

		![](BtnTernaryExpressions;crcommand:OpenFile:TernaryExpressions.cs)

		![](FlattenConditionals;crcommand:OpenFile:FlattenConditionals.cs)

		![](BtnSimplifyExpressions;crcommand:OpenFile:SimplifyExpressions.cs)

		![](BtnBlockDelimiters;crcommand:OpenFile:BlockDelimiters.cs)

		![](BtnNullCoalescing;crcommand:OpenFile:NullCoalescing.cs)

		![](BtnDecomposeParameter;crcommand:OpenFile:DecomposeParameter.cs)
	
		![](BtnConvertToFunction;crcommand:OpenFile:ConvertToFunction.cs)

		![](BtnCombineSplitConditionals;crcommand:OpenFile:CombineSplitConditionals.cs)


	*/

	//`++Great Work!
	/* 
	 Caps+Space is a powerful tool for compressing and expanding code. Use it to 
	 work with expression bodies, ternary or null coalescing expressions, block 
	 delimiters, conditionals, implicit/explicit variable declarations, and a 
	 host of other toggling features. 

	 You also got an introduction to Smart Nav (Caps + arrow keys). Good job!

 ![](NextLesson;crcommand:OpenFile:CapsDelete.cs)

 */

	public class CapsSpace
	{
		/* 
		    [x] Implicit/Explicit Declarations - 1370
		    [x] Expression Bodies - 931
		    [x] Initializers - 656 + 248
		    [x] inline temp - 549
		    [x] Ternary Expressions  - 442
		    [x] flatten conditionals - 304
		    [x] simplify expression - 273
		    [x] add/remove block delimiters - 270
		    [x] Null Coalescing Operations - ?
				[x] Decompose Parameter
		    [x] convert to function - ?
				[ ] expand lambda - ?
		    [ ] Shorter Assignments - ?
		    
	 */

		public void AssignmentCompression(ref int a)
		{//`![](ArrowDown) Caps+Space to compress or expand these assignments: 
			a = a + 3;
			a = a * 3;
			a /= 3;
			a |= 2 * 2 * 2;
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

