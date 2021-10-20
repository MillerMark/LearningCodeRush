namespace CapsModifier
{
	public class ShiftCapsDelete
	{
		/* 
		 ![Enable Rich Comments to see embedded images](ShiftCapsDelete)

		 Use Shift+Caps+Delete to:
		
				* Remove all type qualifiers matching the qualifier at the caret.
				* Remove all redundant brace blocks inside a method.
			 
		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.
		
		*/



		// Use Shift+Caps+Delete to remove all **type qualifiers** matching the type qualifier at the caret.
		//`![](ArrowDown)
		System.AssemblyLoadEventArgs assemblyLoadEventArgs;



		public ShiftCapsDelete()
		{                                                          //`![](ArrowDown)
			assemblyLoadEventArgs = new System.AssemblyLoadEventArgs(System.Reflection.Assembly.GetExecutingAssembly());
		}

		public System.Boolean AssemblyIsDynamic(System.AssemblyLoadEventArgs assemblyLoadEventArgs)
		{
			System.Reflection.Assembly loadedAssembly = assemblyLoadEventArgs.LoadedAssembly;
			if (loadedAssembly.IsDynamic)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		void TestAssembly()
		{
			System.Boolean isDynamic = AssemblyIsDynamic(assemblyLoadEventArgs);
		}



		// Use Shift+Caps+Delete to remove all redundant **block delimiters** inside this method,
		// available on the first token of the method declaration.
		//`![](ArrowDown)
		static void Main(string[] args)
		{
			System.Console.Write("Even numbers:");
			for (int i = 1; i <= 10; i++)
			{
				if (i % 2 == 0)
				{
					System.Console.Write($" {i}");
				}
				else
				{
					// Skipping odd numbers.
				}
			}
			System.Console.ReadKey();
		}
	}

	//`++Great Work!
	/* 
	 You used Shift+Caps+Delete to remove all type qualifiers and to remove 
	 all redundant brace blocks inside a method. 

		![](NextLesson;crcommand:OpenFile:ShiftCapsF.cs)  << Shift+Caps+F to rename types to match a File and more...

 */

}


