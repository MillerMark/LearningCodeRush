using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsInsert
	{
		//`![Enable Rich Comments to see embedded images](CapsInsert)

		/* 
		 Use Caps+Insert to add new code, including:

			* Add Missing Constructors
			* Add to Interface
			* Add Parameters

		 You can also use Caps+Insert to add Getters, Setters, and Else statements

		 Examples are below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

	 */

		//`                         ![](ArrowDown) Caps+Insert to add a setter.
		public int NeedsSetter { get; }

		int needsGetter;
		bool started;
		public int NeedsGetter
		{	//`![](ArrowDown) Caps+Insert to add a getter.
			set => needsGetter = value;
		}

		//` ![](Add Parameter;https://www.youtube.com/watch?v=KAtOxMQyg3g&list=PL8h4jt35t1wgawacCN9wmxq1EN36CNUGk&index=4 )  << More on Add Parameter.

		internal void TestStart()
		{
			//`                            ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			Start(TimeSpan.FromSeconds(5), Guid.Empty, 25);
		}

		//`![](BtnTextFields;crcommand:OpenFile:TextFields.cs)  << Learn about Text Fields.


		//`            Caps+Insert ![](ArrowDown) to add a new parameter (e.g., "bool fast").
		void Start(TimeSpan age, Guid id, int count)
		{
			started = true;
		}

		//`++ Pro Tip - Smart Cut/Copy
		// CodeRush lets you cut and copy identifiers without selecting them.
		// Just place the caret inside the identifier and press the copy or 
		// cut keys (e.g., Ctrl+C, Ctrl+Insert, etc.).

		//` ![](SmartCutCopyPasteReplace;https://www.youtube.com/watch?v=KxJO1V-W2lI&list=PL8h4jt35t1wgawacCN9wmxq1EN36CNUGk&index=25 )  << More on Smart Cut/Copy.


		void CompleteTasks()
		{
			
			//`        ![](ArrowDown) Ctrl+C copies this identifier (no need to select).
			string greeting = "CodeRush Rocks!";

			//  (paste it as a new argument below)


			// You can add new parameters from a method's call site:

			if (!started)
			{
				//`         ![](ArrowDown) Caps+Insert to add greeting as a new parameter.
				LateStart(50, TimeSpan.FromSeconds(5));
			}//` ![](ArrowLeft) Caps+Insert to add an else block.
		}

		void LateStart(int count, TimeSpan timeSpan)
		{
			
		}


		//`++ Pro Tip
		// You can use CodeRush templates inside of text fields. So if you 
		// need a "string" for a new parameter, you can enter "ts" (stands
		// for "type - string") and then press the Space bar or Tab key to
		// expand the template.

		// If you need a list of strings, enter "tl.s" (stands for "type -
		// list of strings").

		// You can enable Templates on the Quick Setup options page. ![](Gear;crcommand:Options:Quick Setup)

		//` ![](T for Types;https://www.youtube.com/watch?v=WiGSSxFLNhI&list=PL8h4jt35t1wgawacCN9wmxq1EN36CNUGk&index=22 )  << More on Type templates.


		// Try using "ts" (or "tl.s") on the next example! 


		internal void TestComplete()
		{
			//`                 ![](LookHere;;;0.006,0.006) Look here when you try the next one.
			Complete(Guid.Empty);
		}


		//`                    ![](ArrowDown) Caps+Insert to add a new parameter.
		void Complete(Guid id)
		{

		}
	}



	interface IPerson
	{
		string FullName { get; set; }
	}

	class Person : IPerson
	{
		public string FullName { get; set; }

		// TODO: Binding does not work. Remove if not fixed in time!!!
		//`              ![](ArrowDown) Caps+Insert to add this property to the IPerson interface.
		public string MobilePhone { get; set; }
	}





	//`              ![](ArrowDown) Press Caps+Insert to add missing constructors.
	public class ChildClass : BaseClass
	{

	}

	//`++Great Work!

	/* 
	You used Caps+Insert to add new parameters, constructors, and more.
	

	![](NextLesson;crcommand:OpenFile:CapsDot.cs)  << Caps+. to expand and collapse code formatting

	*/
}


