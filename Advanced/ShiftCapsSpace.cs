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
		 Use Shift+Caps+Space to work with tuples, system types, and 
		 built-in types.
		
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
			//`       ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			AddBook("The Hitchhiker's Guide to the Galaxy", "D. Adams");
			AddBook("The Hobbit, or There and Back Again", "J.R.R. Tolkien");
		}

		private List<Book> shelf = new List<Book>();

		//`             ![](ArrowDown) Shift+Caps+Space to convert these parameters into a Tuple: 
		public void AddBook(string Title, string Author)
		{
			shelf ??= new List<Book>();

			//`                   ![](LookHere;;;0.006,0.006) Also look here when you try this one.
			shelf.Add(new Book(Title, Author, DateTime.Now));
		}
	}



	//`++Great Work!
	/* 
	Use Shift+Caps+Space to go toggle between system and built-in types. 

	![](NextLesson;crcommand:OpenFile:ShiftCapsDelete.cs)  << Shift+Caps+Delete for larger removal operations...

	*/
}

