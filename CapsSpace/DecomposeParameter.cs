using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CapsModifier
{
	public class DecomposeParameter
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to decompose parameters into more useful parts.


		public string GetThisEncodedPath()
		{
			Assembly ea = Assembly.GetExecutingAssembly();

			//`                     ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			return GetEncodedPath(ea);
		}

		//`                  Caps+Space ![](ArrowDown) to Decompose this Parameter
		public string GetEncodedPath(Assembly assembly)
		{
			if (assembly.IsDynamic)
				return "Dynamic:" + Path.GetDirectoryName(assembly.Location);
			else
				return "Static:" + Path.GetDirectoryName(assembly.Location);
		}

		//` ![](Decompose Parameter2;https://www.youtube.com/watch?v=_sTWyDjd4oY&list=PL8h4jt35t1wgawacCN9wmxq1EN36CNUGk&index=12 )  << More on Decompose Parameter.
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:ExpandLambda.cs) << Expand Lambda and more...
}

