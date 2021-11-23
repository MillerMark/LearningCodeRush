interface IPerson
{
	string FullName { get; set; }
}

class Person : IPerson
{
	public string FullName { get; set; }

	//`              ![](ArrowDown;;;0.008,0.008) Caps+Insert to add this property to the IPerson interface.
	public string MobilePhone { get; set; }
}

//`![](BtnMoreLikeThis;crcommand:OpenFile:AddElseBlock.cs;;0.04,0.04) << Add Else Block and more...
