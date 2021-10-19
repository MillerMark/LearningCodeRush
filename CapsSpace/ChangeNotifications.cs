using System;
using System.ComponentModel;
using System.Linq;

namespace CapsModifier
{
	public class ChangeNotifications
	{
		//`![Enable Rich Comments to see embedded images](CapsSpace) Caps+Space to add change notifications.
	}

	//! Note: InterstellarRocket implements INotifyPropertyChanged!!!
	// Caps+Space can help you with INotifyPropertyChanged (see below)...
	public class InterstellarRocket : INotifyPropertyChanged
	{
		double fuelLevel;
		public event PropertyChangedEventHandler PropertyChanged;



		//`![](ArrowDown) Caps+Space adds change notification (in setter) to an existing property: 
		public double FuelLevel
		{
			get => fuelLevel;
			set => fuelLevel = value;
		}



		double payloadTotalWeight;
		//`![](ArrowDown) Caps+Space converts to a property with a change notification: 
		public double PayloadTotalWeight
		{
			get => payloadTotalWeight; set
			{
				if (payloadTotalWeight == value)
					return;
				payloadTotalWeight = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PayloadTotalWeight)));
			}
		}
	}
}

