using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace CapsModifier
{
	public class ShiftCapsSpace
	{

		//`![Enable Rich Comments to see embedded images](ShiftCapsSpace)

		/* 
		 Use Shift+Caps+Space to work with tuples, system types, built-in types, 
		 conditionals and switch/case statements.
		
		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		*/


		//`![](ArrowDown) Shift+Caps+Space to convert between built-in and system types: 
		bool started;

		//`![](ArrowDown) 
		long latitude;

		//`![](ArrowDown) 
		Int32 id;

		//`![](ArrowDown) 
		Int16 appNumber;




		public void AddBooks()
		{
			//`       ![](LookHere) Look here when you try the next one.
			AddBook("The Hitchhiker's Guide to the Galaxy", "D. Adams");
			AddBook("The Hobbit, or There and Back Again", "J.R.R. Tolkien");
		}

		private List<Book> shelf = new List<Book>();

		//`             ![](ArrowDown) Shift+Caps+Space to convert these parameters into a Tuple: 
		public void AddBook(string Title, string Author)
		{
			shelf ??= new List<Book>();

			//`                   ![](LookHere) Also look here when you try this one.
			shelf.Add(new Book(Title, Author, DateTime.Now));
		}

		string phoneNumber;
		//`![](ArrowDown) Shift+Caps+Space to make property (with backing field) auto-implemented: 
		public string PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
			set
			{
				phoneNumber = value;
			}
		}
	}

	public enum Flavors
	{
		Vanilla,
		Chocolate,
		Strawberry
	}
	
	public static class Utils
	{
		static int numVanillaLikes;
		static int numChocolateLikes;
		static int numStrawberryLikes;
		
		public static double GetTotal(IEnumerable<object> values)
		{
			double sum = 0;

			foreach (var item in values)
			{
				//`![](ArrowDown) Press Shift+Caps+Space to convert this Switch statement into an if/then conditional.
				switch (item)
				{
					case int val:
						sum += val;
						break;
					case IEnumerable<object> sublist:
						sum += GetTotal(sublist);
						break;
					default:
						sum += 0.5;
						break;
				}
			}
			return sum;
		}

		public static void Like(Flavors flavor)
		{
			//`![](ArrowDown) Press Shift+Caps+Space to convert this Conditional statement into a Switch/Case statement.
			if (flavor == Flavors.Chocolate)
			{
				numChocolateLikes++;
			}
			else if (flavor == Flavors.Strawberry)
			{
				numStrawberryLikes++;
			}
			else if (flavor == Flavors.Vanilla)
			{
				numVanillaLikes++;
			}
		}
	}


	//`++Great Work!
	/* 
	 Use Shift+Caps+Space to go toggle between system and built-in types. 

	 ![](NextLesson;crcommand:OpenFile:ShiftCapsDelete.cs)  << Shift+Caps+Delete for larger removal operations...

 */
}

