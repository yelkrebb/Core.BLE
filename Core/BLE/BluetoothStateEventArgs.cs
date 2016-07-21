using System;

namespace Motion.Mobile.Core.BLE
{
	public class BluetoothStateEventArgs : EventArgs
	{
		public BluetoothLEStates BTState;
		public BluetoothStateEventArgs () : base()
		{}
	}
}

