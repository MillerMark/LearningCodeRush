using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	public class CapsG
	{
		//`![Enable Rich Comments to see embedded images](CapsG)

		/* 
		 Caps+G lets you add Getters to properties and work with Generic 
		 type parameters.
		 
		 
		 Use Caps+G to:
		
				* Add a Getter to a property
				* Promote a parameter type or a return type to a Generic type parameter
			 
		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		*/


		void SetRules<V>(V verifier) where V : Trimmer
    {
      verifier.TrimSpaces = true;
    }

		public void LogText(string text)
		{
			//`                           ![](LookHere) Look here when you try the next one.
			string verifiedText = Check(new Trimmer(), text);
			Console.WriteLine(verifiedText);
		}

		//`                    ![](ArrowDown) Press Caps+G to promote this to a type parameter.		
		public string Check(Trimmer verifier, string text)
    {
			//`         ![](LookHere) Also look here when you try this one.
			SetRules<Trimmer>(verifier);
      return verifier.CheckText(text);
    }

		//`       ![](ArrowDown) Press Caps+G to promote this to a type parameter.		
		public Trimmer GetVerifier(string verifierName)
		{
			IChecker checker = checkers.FirstOrDefault(x => x.Name == verifierName);
			return checker as Trimmer;
		}

		List<IChecker> checkers = new List<IChecker>();
			
		public interface IChecker
		{
			string Name { get; }
		}

		public class Trimmer: IChecker
		{
			public string CheckText(string text)
			{
				var validatedText = text ?? "";
				if (TrimSpaces)
					validatedText = validatedText.Trim();
				return validatedText;
			}
			public bool TrimSpaces { get; set; }

			public string Name => nameof(Trimmer);
		}


		//`++Great Work!
		/* 
		 You used Caps+G to promote both parameter types and return types to 
		 Generic type parameters.

	 ![](NextLesson;crcommand:OpenFile:CapsH.cs)  << Caps+H for Copyright headers...

	 */


	}
}
