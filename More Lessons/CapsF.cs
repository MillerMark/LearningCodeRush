using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	public abstract class CapsF
	{
		//`![](CapsF;;;0.04,0.04)

		/*
		Caps+F lets you declare Fields, work with For and Foreach loops, and 
		convert void procs to Functions.
		
		Use Caps+F to:
		
			* Convert to Function
			* Declare Fields
			* ForEach to For (and back)
			* Format Selection
			* Move Type to File
			* Widen Scope (Promote to Field)

		Examples follow in the source code below.

		Arrows (![](ArrowDown;;;0.008,0.008)) show caret position. 

		Move to where the arrow points before pressing the shortcut.
		
		*/


		public abstract void Start();
		public abstract void ReadData();
		public abstract void Draw();
		public abstract void FinishDrawing();
		public abstract void DoMoreWork();


		public class GreetingsSender
		{
			private const int minAuthorizationsNeeded = 5;

			public void Start(int authorizationCount, bool allSystemsReady)
			{
				//` ![](ArrowDown;;;0.008,0.008)  Press Caps+F to declare "readyToLaunch" as a field (arrows & Enter pick location)
				readyToLaunch = authorizationCount >= minAuthorizationsNeeded && allSystemsReady;
			}
		}


		//`![](ArrowDown;;;0.008,0.008) Caps+F to convert this unimplemented property into one with a backing field variable:
		public decimal LifetimeCustomerValue
		{
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}


		void ConcatLongerThan(List<string> strings, int minLength)
		{
			string result = string.Empty;

			//`![](ArrowDown;;;0.008,0.008) Press Caps+F to convert this foreach into a for loop:
			foreach (string str in strings)
				if (str.Length > minLength)
					result += $"{str};";
		}




		internal List<int> GetOdd(List<int> numberList)
		{
			List<int> results = new List<int>();

			//`![](ArrowDown;;;0.008,0.008) Press Caps+F to convert this for-loop into a foreach:
			for (int i = 0; i < numberList.Count; i++)
				if (numberList[i] % 2 == 0)
					results.Add(numberList[i]);

			return results;
		}

		public int callCount;
		bool trackingResults;
		public int negativeCount;
		public int positiveCount;


		//`![](ArrowDown;;;0.008,0.008) Press Num Plus (or Ctrl W) to select this method, then Caps+F to format the selection:
		public int CalculateIt(int factor, int multiplier)
		{
var resultValue=multiplier*factor   ;
                                       			callCount  ++; 
			
			if(  trackingResults  )
										{
																if(resultValue<0)
negativeCount     ++            ;
																else                         if(resultValue>0)
														positiveCount     ++            ;
																																			}

			                         return                                    resultValue                       ;
		}
	}

	//` ![](Selection IncreaseDecrease;https://www.youtube.com/watch?v=cdJ4D3xmnFw ;;0.04,0.04)  << More on Selection Increase/Decrease



	//`![](ArrowDown;;;0.008,0.008) Press Caps+F to move this type to its own file (and then use Escape or Alt+End to get back):
	public class Automobile
	{
		public string Model { get; set; }
		public int Year { get; set; }
		public Guid ID { get; set; }
		public Automobile()
		{
			//` ![](BtnMarkers;crcommand:OpenFile:Markers.cs;;0.04,0.04)  << Learn about Markers.
		}
	}


	public class SiteLoader
	{
		bool IsValid(string completeUrl)
		{
			throw new NotImplementedException();
		}


		//`       Press Caps+F ![](ArrowDown;;;0.008,0.008) to declare a field variable initialized to this parameter:
		void SetName(string siteName)
		{

		}



		public void SetUrl(string url)
		{
			//`        ![](ArrowDown;;;0.008,0.008) Press Caps+F to turn "completeUrl" into a field variable:
			string completeUrl = $"http://{url}";



			if (!IsValid(completeUrl))
				throw new Exception($"\"{completeUrl}\" has errors!");
		}
	}

	//`++Great Work!

	/*
	You used Caps+F to declare Fields & Fields with initializers, convert 
	between ForEach statements and  For loops, Format selections, move 
	types to Files, and promote local variables into Fields. */

	//`![](GotIt;vscommand:File.Close)
}
