using System;
using System.Linq;
using System.Diagnostics;

namespace CapsModifier
{
	public partial class InlineLambda
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.03000,0.03000) to inline a delegate to a lambda.

		public InlineLambda()
		{
			InitializeComponent();

			//`  Caps+Space ![](ArrowDown;;;0.008,0.008) to inline the event handler (below) as a lambda: 
			Loaded += Control_Loaded;
		}

		private void Control_Loaded(object sender, RoutedEventArgs e)
		{
			if (sender != null)
				Debug.WriteLine($"Control_Loaded: {sender.ToString()}");
			else
				Debug.WriteLine($"Control_Loaded: (null sender)");
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:ConvertToFunction.cs;;0.04,0.04) << Convert to Function and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.02,0.02)  << Skip ahead to the next lesson (Caps+Delete)...
