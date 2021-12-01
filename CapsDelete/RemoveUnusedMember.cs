﻿using System;
using System.Linq;

namespace CapsModifier
{
	//`![](CapsPlusDelete;crcommand:OpenFile:CapsDelete.cs;;0.03000,0.03000) removes unused members.

	public class RemoveUnusedMember
	{
		// Caps+Delete to remove the unused member:
		//`     ![](ArrowDown;;;0.008,0.008)
		void Button1_Clicked(object sender, EventArgs ea)
		{
			if (sender == null || ea == null)
				return;
		}

		public bool Started { get; set; }
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:RemoveAllRedundantBlockDelimiters.cs;;0.04000,0.04000) << Remove All Redundant Block Delimiters and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.04,0.04)  << Skip ahead to the next lesson (Caps+Insert)...
