namespace CapsModifier
{
	public class CapsR
	{
		/*
		![](CapsR;;;0.03,0.03)

		Use Caps+R to Reorder Parameters.

			![](Reorder Parameters;https://www.youtube.com/watch?v=tdwW4dsRSUQ&list=PL8h4jt35t1wgawacCN9wmxq1EN36CNUGk&index=4 ;;0.04000,0.04000) << Learn more about Reorder Parameters.
		 
		*/

		// Use Caps+R to Reorder Parameters.
		// Use the **Tab** and **Arrow** keys to select and move parameters.
		// Enter accepts. Escape cancels.

		//`                       Caps+R ![](ArrowDown;;;0.008,0.008) to get these parameters in the right order:
		internal void LotsOfParameters(string msg2, double y, string msg1, double z, double x)
		{

		}

		internal void CallingMethod()
		{
			double x = 1;
			double y = 2;
			double z = 3;

			// You can also Reorder Parameters from a *calling method*:

			//`            Caps+R ![](ArrowDown;;;0.008,0.008) to reorder these parameters:
			LotsOfParameters("Message 2", y, "Message 1", z, x);
		}
	}


	//`++Great Work!
	/*
	You used Caps+R to Reorder Parameters.                                     */

	//`![](GotIt;vscommand:File.Close;;0.04,0.04)
}
