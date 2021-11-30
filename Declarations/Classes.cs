using System;

namespace CapsModifier
{
	public class Classes
	{
		static void CreateTestFlyer(string firstName, string lastName, string birthDate)
		{
			//`                    Caps+C ![](ArrowDown;;;0.008,0.008) to declare a new class "FrequentFlyer".
			FrequentFlyer jane = new FrequentFlyer(firstName, lastName);
			jane.BirthDate = DateTime.Parse(birthDate);
			jane.JoinDate = DateTime.Now;
			jane.SendWelcomeMessage();
		}

		//`![](BtnMoreWithCapsC;crcommand:OpenFile:CapsC.cs;;0.03,0.03) << Caps+C can do even more!
	}
}


	//`++Great Work!
	/*
		You used these shortcuts to declare these code elements:

			![](BtnInstantDeclareTable;;;0.02,0.02)

		![](NextLesson;crcommand:OpenFile:MoreCapsShortcuts.cs;;0.04000,0.04000)  << More Caps shortcuts...
	*/
}
