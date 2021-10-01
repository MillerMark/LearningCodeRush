using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

namespace CapsModifier
{
	public class ShiftCapsR
	{
		/* 
		 ![Enable Rich Comments to see embedded images](ShiftCapsR)

		 Use Shift+Caps+R to Reverse Boolean Logic.

		 Sometimes you have a boolean with wrong name.

		 For example, _DataNotFound has the word "Not" in it, making it harder
		 to read. But before we can rename it to "_DataFound", we have to
		 reverse all its boolean logic.

		 */



		//    Caps+Shift+R ![](ArrowDown) to reverse this field's boolean logic.
		private bool _DataNotFound;

		public void CheckData()
		{
			//            ![](LookHere) Reverse boolean changes will be here.
			_DataNotFound = !DataProcessor.FindData();
		}

		public void ProcessData()
		{
			//   ![](LookHere) Reverse boolean changes will be here as well.
			if (_DataNotFound)
				return;
			DataProcessor.OutputDataInfo(_Data);
		}

		private object _Data;
	}

	//`++Great Work!

	/* 
	 You used Caps+Shift+R to reverse boolean logic in a field variable.

	 That completes our LearningCodeRush solution. We hope you enjoyed it.

	 To learn more about CodeRush, check out the Feature of the Week playlist 
	 on YouTube:

		![](Tab to Next Reference;https://www.youtube.com/playlist?list=PL8h4jt35t1wgawacCN9wmxq1EN36CNUGk ) << More on CodeRush Features

	 As always, we welcome your thoughts. Let us know what you think about 
	 this training solution. If you have specific questions or need assistance 
	 with CodeRush, feel free to contact us through our Support Center 
	 (support@devexpress.com) or click the link below:

	 ![](SubmitSupportTicket;https://supportcenter.devexpress.com/ )

	*/
}


