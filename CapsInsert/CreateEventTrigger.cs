using System;

public class CreateEventTrigger
{

	//`![](BtnTargetPicker;crcommand:OpenFile:TargetPicker.cs;;0.04,0.04) << Learn more about the Target Picker...

	//`                  Caps+Space ![](ArrowDown;;;0.008,0.008) to create an event trigger: 
	public event EventHandler Started;

	//`                              Caps+Space ![](ArrowDown;;;0.008,0.008) to create an event trigger: 
	public event EventHandler<FinishedData> Ended;

	public CreateEventTrigger()
	{

	}
}

//`![](BtnMoreLikeThis;crcommand:OpenFile:AddGetterSetter.cs;;0.04,0.04) << Add Getter/Setter...



