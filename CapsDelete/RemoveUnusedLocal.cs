using System;

public class RemoveUnusedLocal
{
	//`![](CapsPlusDelete;crcommand:OpenFile:CapsDelete.cs;;0.03000,0.03000) removes unused locals.

	public int BruteForceAddition(int num1, int num2)
	{
		if (num1 == 0)
			return num2;

		// Caps+Delete to remove the unused local:
		//`        ![](ArrowDown;;;0.008,0.008)
		string unusedLocalVariable = null;

		int step = 1;

		// ![](LookHere;;;0.008,0.008) Look here when you try the one above.
		unusedLocalVariable = "Yo";

		if (num2 < 0)
			step = -1;

		int answer = num1;
		for (int i = 0; i < Math.Abs(num2); i++)
			answer += step;

		return num1;
	}
}

//`![](BtnMoreLikeThis;crcommand:OpenFile:RemoveUnusedType.cs;;0.04000,0.04000) << Remove Unused Type and more...



//`![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.02,0.02)  << Skip ahead to the next lesson...
