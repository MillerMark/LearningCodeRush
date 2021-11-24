using System;
using System.Linq;
using System.Collections.Generic;

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
			//`        ![](ArrowDown;;;0.008,0.008) Caps+F to turn local "completeUrl" into a Field variable:
			string completeUrl = string.Format("http://{0}?{1}", url, userName);

			if (!IsValid(completeUrl))
				throw new Exception($"\"{completeUrl}\" has errors!");
		}


		//`![](ArrowDown;;;0.008,0.008) Caps+F to create a backing store Field for this "Not Implemented" property:
		public DateTime LastLogin
		{
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}
	}
}
