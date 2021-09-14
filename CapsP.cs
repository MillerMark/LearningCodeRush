using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

namespace CapsModifierTests
{
	public class CapsP
	{
		/* 
		 ![Enable Rich Comments to see embedded images](CapsP)

		 Use Caps+P to:
		
				* Add Parameters
				* Decompose Parameters
				* Promote to Generic Parameter
				* Promote to Parameter
				* Pull Members Up
			 
		 Examples follow in the source code below.
		*/

		AssemblyLoadEventArgs assemblyLoadEventArgs;

		public string GetThisEncodedPath()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();

			//`                     ![](LookHere) Look here when you try the next one.
			return GetEncodedPath(executingAssembly);
		}

		// Press Caps+P to Decompose this Parameter:
		//`                             ![](ArrowDown)
		public string GetEncodedPath(Assembly assembly)
		{
			if (assembly.IsDynamic)
				return "Dynamic:" + Path.GetDirectoryName(assembly.Location);
			else
				return "Static:" + Path.GetDirectoryName(assembly.Location);
		}

		public string GetEncodedPath2(Assembly assembly)
		{
			if (assembly.IsDynamic)
				return "Dynamic:" + Path.GetDirectoryName(assembly.Location);
			else
				return "Static:" + Path.GetDirectoryName(assembly.Location);
		}

		public CapsP()
		{
			assemblyLoadEventArgs = new AssemblyLoadEventArgs(System.Reflection.Assembly.GetExecutingAssembly());

			//`        ![](LookHere) Look here when you try the next one.
			SayHello();
		}

		public void SayHello()
		{
			// Press Caps+P to Promote userName to a parameter:
			//`        ![](ArrowDown)
			string userName = "Mark";
			Console.WriteLine($"Greetings, {userName}!");
		}

		//`                         ![](LookHere) Look here when you try the next one.
		void SayGoodbye(string message)
		{
			Console.WriteLine($"Until next time! {message}");
		}

		void EndSession()
		{
			string userName = "Rory";
			// Press Caps+P to add a new Parameter. First move the 
			// caret to where you want the new parameters to go, then 
			// press Caps+P. Specify the value/expression to pass in
			// (you can use the userName local, above, if you like).
			// CodeRush will do the rest.
			//`                         ![](ArrowDown)
			SayGoodbye("This was fun!");
		}

		// Press Caps+P to Promote "Tool" to a generic parameter:
		//`![](ArrowDown)
		public Tool GetTool(string id)
		{
			return null;
		}
	}

	public class BaseTool
	{
		public BaseTool()
		{
			
		}
		// When the target picker is up, use Up/Down arrows and Enter to select the target location.
	}

	public class Tool: BaseTool
	{
		public Tool()
		{

		}

		public Tool(string id)
		{
			Id = id;
		}

		public string Id { get; }

		// Use Caps+P to Pull this Engage() member up to the parent class BaseTool.
		// Use arrow keys to position it, and Enter to accept (or Escape to cancel).
		//` ![](ArrowDown)
		public void Engage()
		{
			
		}
	}
}


