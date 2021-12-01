using System;
using System.ComponentModel;
using System.Linq;

namespace CapsModifier
{
	public class ChangeNotifications
	{
		//`![](CapsSpace;;;0.03,0.03) Caps+Space to add change notifications.
	}

	//! Note: InterstellarRocket implements INotifyPropertyChanged!!!
	// Caps+Space can help you with INotifyPropertyChanged (see below)...
	public class InterstellarRocket : INotifyPropertyChanged
	{
		double fuelLevel;
		public event PropertyChangedEventHandler PropertyChanged;



		//`![](ArrowDown;;;0.008,0.008) Caps+Space adds change notification (in setter) to an existing property: 
		public double FuelLevel
		{
			get => fuelLevel;
			set => fuelLevel = value;
		}



		double payloadTotalWeight;
		//`![](ArrowDown;;;0.008,0.008) Caps+Space converts to a property with a change notification: 
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

