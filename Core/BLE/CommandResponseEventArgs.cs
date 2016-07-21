using System;

namespace Motion.Mobile.Core.BLE
{
	public class CommandResponseEventArgs : EventArgs
	{
		public byte[] Data;

		public CommandResponseEventArgs () : base()
		{}
	}
}

