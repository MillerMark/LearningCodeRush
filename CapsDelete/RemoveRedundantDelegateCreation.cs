using System;

public class RemoveRedundantDelegateCreation
{
	//`![](CapsPlusDelete;crcommand:OpenFile:CapsDelete.cs;;0.03000,0.03000) removes redundant delegate creation.

	public void HookEvents()
	{
		// Caps+Delete ![](ArrowDown;;;0.008,0.008) to remove the redundant delegate creation:
		TextChanged += new EventHandler(ProcessText);
	}

	void ProcessText(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	public event EventHandler TextChanged;
}

//`![](BtnMoreLikeThis;crcommand:OpenFile:RemoveUnusedLocal.cs;;0.04000,0.04000) << Remove Unused Local and more...



//`![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.02,0.02)  << Skip ahead to the next lesson...
