using System;

namespace Motion.Mobile.Core.BLE
{
	public class DeviceConnectionEventArgs : EventArgs
	{
		public IDevice Device;
		public string ErrorMessage;

		public DeviceConnectionEventArgs() : base()
		{}
	}
}

