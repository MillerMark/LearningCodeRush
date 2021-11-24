using System;
using System.Linq;

namespace CapsModifier
{
	public partial class RemoveAllRedundantBlockDelimiters
	{
		//`![](CapsPlusDelete;crcommand:OpenFile:CapsDelete.cs;;0.03000,0.03000) removes all redundant **block delimiters** 

		// Use Caps+Delete to remove all redundant **block delimiters** inside
		// this method, available on the first token of the method declaration.
		//`![](ArrowDown;;;0.008,0.008)
		static void Main(string[] args)
		{
			Console.Write("Even numbers and primes:");
			if (args.Length == 0)
			{
				for (int i = 1; i <= 10; i++)
				{
					if (i % 2 == 0)
					{
						System.Console.Write($" {i}");
					}
					else if (IsPrime(i))
					{
						System.Console.Write($" {i} is Prime!");
					}
				}
			}

			System.Console.ReadKey();
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:RemoveUnusedParameter.cs;;0.04000,0.04000) << Remove Unused Parameter and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.02,0.02)  << Skip ahead to the next lesson (Caps+Insert)...
