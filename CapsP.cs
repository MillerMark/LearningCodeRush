using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

namespace CapsModifier
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
				* Reorder Parameters
				* Declare Parameter
				* Declare Partial Class Part
				* Declare Property (auto-implemented)
				* Declare Property (with default body)
				* Declare Property with Initializer
			 
		 Examples follow in the source code below.
		*/

		AssemblyLoadEventArgs assemblyLoadEventArgs;

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

	public class Tool : BaseTool
	{
		public Tool()
		{

		}

		public Tool(string id)
		{
			Id = id;
		}

		public string Id { get; }
		bool engaging;

		// Use Caps+P to Pull this Engage() member up to the parent class BaseTool.
		// Use arrow keys to position it, and Enter to accept (or Escape to cancel).
		//` ![](ArrowDown)
		public void Engage()
		{
			engaging = true;
		}

		public void RockOn()
		{
			engaging = false;
			double x = 0, y = 0, z = 0;
			//`                       ![](LookHere) Look here after you try the next one.
			LotsOfParameters("End", y, "Start", z, x);
		}


		// Use Caps+P to Reorder Parameters.
		// Use the tab and arrow keys to select and move parameters.
		// Enter accepts (Escape cancels).
		//`                      ![](ArrowDown)
		void LotsOfParameters(string msg2, double Y, string msg1, double Z, double X)
		{

		}

		void CallingMethod()
		{
			// You can also use Caps+P to Reorder Parameters from a *calling method*.
			//                  ![](ArrowDown)
			LotsOfParameters("Message 2", 2, "Message 1", 3, 1);
		}

		public static double ConvertToUSD(double amount)
		{
			// Press Caps+P to declare "source" as a parameter.
			//`                                  ![](ArrowDown)
			return amount / GetCurrencyRate(source);
		}

		protected static double GetCurrencyRate(Currency source)
		{
			// Press Caps+P to declare "LastSelected" as a property:
			//`   ![](ArrowDown)
			LastSelected = source;
			throw new NotImplementedException();
		}

		public enum Currency
		{
			USD,
			EUR,
			GBR
		}
	}

	// Press Caps+P to create a partial class part:
	//`   ![](ArrowDown)
	public class MyUtils
	{
		
		
	}
}


