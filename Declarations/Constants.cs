namespace CapsModifier
{
	public class Constants
	{
		//`![](CapsQ;crcommand:OpenFile:CapsQ.cs;;0.03000,0.03000) declares Constants

		public static string GetRelativePath(string str)
		{//                                        ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			int parentFolderIndex = str.IndexOf(@"\wwwroot\GameDev\Assets\");
			if (parentFolderIndex >= 0)//`             Caps+Q ![](ArrowDown;;;0.008,0.008) to declare a constant.
				return str.Substring(parentFolderIndex + @"\wwwroot\GameDev\Assets\".Length);
			return null;
		}


		public double Circumference(double radius)
		{
			return 6.283185307179586476925286766559 * radius;
		}

		public double AreaCircle(double radius)
		{
			//           ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			return 6.283185307179586476925286766559 * radius * radius / 2;
		}

		public double VolumeSphere(double radius)
		{//`             Caps+Q ![](ArrowDown;;;0.008,0.008) to declare a constant (name it Tau).
			return 2/3 * 6.283185307179586476925286766559 * radius * radius * radius;
		}
	}


	//`++Great Work!
/*
	You used:
	
		* Caps+M to declare Methods.
		* Caps+P to declare Properties.
		* Caps+A to declare Auto-implemented Properties.
		* Caps+F to declare Fields
		* Caps+L to declare Locals
		* Caps+C to declare Classes.
		* Caps+Q to declare Constants.

	Nice!


	![](NextLesson;crcommand:OpenFile:MoreCapsShortcuts.cs;;0.04000,0.04000)  << More Caps shortcuts...
*/
}
