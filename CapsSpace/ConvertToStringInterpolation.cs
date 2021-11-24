using System;
using System.Linq;

namespace CapsModifier
{
	//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.03000,0.03000) converts a string.Format call to an interpolated string.

	public class ConvertToStringInterpolation
	{
		public ConvertToStringInterpolation(string url, string userName)
		{
			if (url == null || userName == null)
				return;
			//`          Caps+Space ![](ArrowDown;;;0.008,0.008) to convert to an interpolated string:
			completeUrl = string.Format("http://{0}?u={1}", url, userName);
		}

		string completeUrl;
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:ExpandLambda.cs;;0.04,0.04) << Expand Lambda and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.02,0.02)  << Skip ahead to the next lesson (Caps+Delete)...
