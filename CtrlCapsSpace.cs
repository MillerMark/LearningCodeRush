using System;
using System.Linq;
using System.Collections.Generic;

namespace CapsModifier
{
	public class CtrlCapsSpace
	{

		//`![Enable Rich Comments to see embedded images](CtrlCapsSpace)

		/* 
		 Use Ctrl+Caps+Space to convert from system types to built-in types (and back):

		 Examples follow in the source code below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

		*/


		//`![](ArrowDown) Ctrl+Caps+Space to convert between built-in and system types: 
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

		//`             ![](ArrowDown) Ctrl+Caps+Space to convert these parameters into a Tuple: 
		public void AddBook(string Title, string Author)
		{
			shelf = shelf ?? new List<Book>();

			//`                   ![](LookHere) Also look here when you try this one.
			shelf.Add(new Book(Title, Author, DateTime.Now));
		}

		string phoneNumber;
		//`![](ArrowDown) Ctrl+Caps+Space to make property (with backing field) auto-implemented: 
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


	//`++Great Work!
	/* 
	 Use Ctrl+Caps+Space to go toggle between system and built-in types. 

 ![](NextLesson;crcommand:OpenFile:CapsDelete.cs)

 */
}

