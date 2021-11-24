using System;
using System.Linq;

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
	}
}
