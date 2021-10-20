using System;
using System.Linq;
using System.Diagnostics;

namespace CapsModifier
{
	public partial class InlineLambda
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to inline to a lambda.

		public InlineLambda()
		{
			InitializeComponent();

			//`  Caps+Space ![](ArrowDown) to inline the event handler (below) as a lambda: 
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

	//`![](BtnMoreLikeThis;crcommand:OpenFile:ConvertToFunction.cs) << Convert to Function and more...
}
