using System;
using System.Collections.Generic;

namespace Motion.Mobile.Core.BLE
{
	public interface IAdapter
	{
		// events
		event EventHandler<DeviceDiscoveredEventArgs> DeviceDiscovered;
		event EventHandler<DeviceConnectionEventArgs> DeviceConnected;
		event EventHandler<DeviceConnectionEventArgs> DeviceDisconnected;
		event EventHandler<DeviceConnectionEventArgs> DeviceFailedToConnect;
		event EventHandler ScanCompleted;
		//TODO: add this
		//event EventHandler ConnectTimeoutElapsed;

		event EventHandler<CommandResponseEventArgs> CommandResponse;
		event EventHandler<BluetoothStateEventArgs> BluetoothStateUpdated;

		// properties
		bool IsScanning { get; }
		bool IsConnected { get; }
		IList<IDevice> DiscoveredDevices { get; }
		IList<IDevice> ConnectedDevices { get; }

		// methods
		void StartScanningForDevices ();
		void StartScanningForDevices (Guid serviceUuid);

		void StopScanningForDevices ();
		void ConnectToDevice (IDevice device);
		void DisconnectDevice (IDevice device);

		void SendCommand (ICharacteristic chr, byte[] command);

	}
}

