using System;
using System.Linq;

namespace CapsModifier
{
	public class CapsInsert
	{
		//`![Enable Rich Comments to see embedded images](CapsPlusDelete)

		/* 
		 Use Caps+Insert to add new code, including:

			* Add Else Statement
			* Add Getter/Setter
			* Add Missing Constructors
			* Add Parameter
			* Add to Interface; 
			* Add XML Comments

		 Examples are below.

		 Arrows (![](ArrowDown)) show caret position. 

		 Move to where the arrow points before pressing the shortcut.

	 */

		//`                         ![](ArrowDown) Caps+Insert to add a getter.
		public int NeedsSetter { get; }

		int needsGetter;
		public int NeedsGetter
		{//`![](ArrowDown) Caps+Insert to add a getter.
			set => needsGetter = value;
		}


		void Start(TimeSpan lifeTime, Guid id, int maxCount)
		{

		}
	}



	

	//`              ![](ArrowDown) Press Caps+Insert to add missing constructors.
	public class ChildClass : BaseClass
	{

	}

	//`++Great Work!

	/* 
	 You used Caps+Delete to remove unnecessary or unused code, including:
	
	   * Discard Variables
		 * Block Delimiters
		 * Constructors
		 * Destructors
		 * Locals
		 * Parameters
		 * Types

	 ![](NextLesson;crcommand:OpenFile:CapsA.cs)

	 */
}


