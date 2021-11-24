namespace CapsModifier
{
	public class RemoveAllTypeQualifiers
	{
		//`![](ShiftCapsDelete;;;0.04,0.04) removes all type qualifiers matching the qualifier at the caret.

		void TestAssembly()
		{
			//`![](LookHere;;;0.008,0.008) Look here when you try the one below.
			System.Boolean isDynamic = AssemblyIsDynamic(assemblyLoadEventArgs);
		}

		// Use Shift+Caps+Delete to remove all **type qualifiers** matching the qualifier at the caret.
		//`![](ArrowDown;;;0.008,0.008)
		System.AssemblyLoadEventArgs assemblyLoadEventArgs;

		public RemoveAllTypeQualifiers()
		{
			//`                            ![](LookHere;;;0.008,0.008) Watch this change when you try the one above.
			assemblyLoadEventArgs = new System.AssemblyLoadEventArgs(
				System.Reflection.Assembly.GetExecutingAssembly());
			//`     ![](ArrowUp;;;0.008,0.008) This is a different qualifier. Shift+Caps+Delete to remove this plus the
			//          three matching System.Reflection type qualifiers below.
		}

		public string GetImageFolder()
		{
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			string folder = assembly.Location;
			return System.IO.Path.Combine(folder, "Images");
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
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:RemoveUnusedMember.cs;;0.04000,0.04000) << Remove Unused Member and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.02,0.02)  << Skip ahead to the next lesson (Caps+Insert)...
