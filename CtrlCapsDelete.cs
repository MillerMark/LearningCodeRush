namespace CapsModifierTests
{
	public class CtrlCapsDelete
	{
		/* 
		 ![Enable Rich Comments to see embedded images](CtrlCapsDelete)

		 Use Ctrl+Caps+Delete to:
		
				* Remove all type qualifiers matching the qualifier at the caret.
				* Remove all redundant brace blocks inside a method.
			 
		 Examples follow in the source code below.
		
		*/

		// Use Ctrl+Caps+Delete to remove all **type qualifiers** matching the type qualifier at the caret.
		//`![](ArrowDown)
		System.AssemblyLoadEventArgs assemblyLoadEventArgs;
		public CtrlCapsDelete()
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

		// Use Ctrl+Caps+Delete to remove all redundant **block delimiters** inside this method,
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
}


