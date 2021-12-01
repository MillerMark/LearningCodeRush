using System;

public class CreateEventTrigger
{
	//`![](CapsInsert;crcommand:OpenFile:CapsInsert.cs;;0.03,0.03) to create an event trigger.

	//`![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.03,0.03) << Learn more about the Target Picker...

	//`                  Caps+Space ![](ArrowDown;;;0.008,0.008) to create an event trigger: 
	public event EventHandler Started;

	//`                              Caps+Space ![](ArrowDown;;;0.008,0.008) to create an event trigger: 
	public event EventHandler<FinishedData> Ended;

	public CreateEventTrigger()
	{

	}
}


//`++Great Work!
/*
	You used Caps+Insert to add missing constructors, new parameters, 
	members to interfaces, and event triggers.

	Here's your next lesson:

	![](BtnDeclarationsTrim;crcommand:OpenFile:Declarations.cs;;0.04,0.04)  << **Instant declarations**...              */
