
//`![](CapsInsert;crcommand:OpenFile:CapsInsert.cs;;0.03,0.03) to add a member to an interface.

interface IPerson
{
	string FullName { get; set; }
}

class Person : IPerson
{
	public string FullName { get; set; }

	//`              ![](ArrowDown;;;0.008,0.008) Caps+Insert to add this property to the IPerson interface.
	public string MobilePhone { get; set; }

	//`            ![](ArrowDown;;;0.008,0.008) Caps+Insert to add this method to the IPerson interface.
	public void Call()
	{
		throw new System.NotImplementedException();
	}
}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:AddElseBlock.cs;;0.04,0.04) << Add Else Block and more...



//`![](NextLesson;crcommand:OpenFile:Declarations.cs;;0.02,0.02)  << Skip ahead to the next lesson (Declarations)...
