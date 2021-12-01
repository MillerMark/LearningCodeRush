using System;

namespace CapsModifier
{
	public abstract class Fields
	{
		//`![](CapsF;crcommand:OpenFile:CapsF.cs;;0.03000,0.03000) declares Fields


		private const int minAuthorizationsNeeded = 5;

		public void Start(int authorizationCount, bool allSystemsReady)
		{
			//` ![](ArrowDown;;;0.008,0.008)  Press Caps+F to declare "readyToLaunch" as a field (arrows & Enter pick location)
			readyToLaunch = authorizationCount >= minAuthorizationsNeeded && allSystemsReady;
		}

		// Sometimes you need to assign a **parameter** to a **Field** that
		// doesn't exist yet.

		//`       Press Caps+F ![](ArrowDown;;;0.008,0.008) to declare a new Field initialized to this parameter:
		void SetName(string siteName)
		{

		}

		bool IsValid(string completeUrl)
		{
			throw new NotImplementedException();
		}

		public void SetLogin(string url, string userName)
		{
			//`        ![](ArrowDown;;;0.008,0.008) Caps+F to promote this local variable into a Field:
			string completeUrl = $"http://{url}?{userName}";

			if (!IsValid(completeUrl))
				throw new Exception($"\"{completeUrl}\" has errors!");
		}


		//`![](ArrowDown;;;0.008,0.008) Caps+F to create a backing store Field for this "Not Implemented" property:
		public DateTime LastLogin
		{
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}


		//`![](BtnMoreWithCapsF;crcommand:OpenFile:CapsF.cs;;0.03,0.03) << Caps+F can do even more!
	}

	//`![](BtnCapsL-LocalsTrim;crcommand:OpenFile:Locals.cs;;0.04,0.04) << Next topic in the guided tour...
}



//`![](NextLesson;crcommand:OpenFile:MoreCapsShortcuts.cs;;0.04,0.04)  << Skip ahead to the next lesson (More Caps Shortcuts)...
