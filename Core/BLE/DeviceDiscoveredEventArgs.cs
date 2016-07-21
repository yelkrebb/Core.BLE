using System;

namespace Motion.Mobile.Core.BLE
{
	public class DeviceDiscoveredEventArgs : EventArgs
	{
		public IDevice Device;
		public int RSSI;

		public DeviceDiscoveredEventArgs() : base()
		{}
	}
}

