using System;

namespace CapsModifier
{
	public class Properties
	{
		/* 
		![](CapsP;crcommand:OpenFile:CapsP.cs;;0.03000,0.03000) declares Properties

		*/


		protected double GetCurrencyRate(Currency source)
		{
			// Press Caps+P to declare "LastSelected" as a property:
			//`   ![](ArrowDown;;;0.008,0.008)
			LastSelected = source;
			throw new NotImplementedException();
		}

		// Sometimes you need to assign a **parameter** to a **Property** that
		// doesn't exist yet.


		//`                  Caps+P ![](ArrowDown;;;0.008,0.008) to declare an **initialized property**:
		public void Start(string city)
		{
		}

		//`![](BtnMoreWithCapsP;crcommand:OpenFile:CapsP.cs;;0.03,0.03) << Caps+P can do even more!
	}

	//`![](BtnCapsA-AutoImplemented;crcommand:OpenFile:AutoImplementedProperties.cs;;0.04,0.04) << Next topic in the guided tour...
}



//`![](NextLesson;crcommand:OpenFile:CapsDot.cs;;0.02,0.02)  << Skip ahead to the next lesson (Caps+.)...


