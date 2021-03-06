﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using SpineHelper.Device;
using System.Management;
using System.Threading;

namespace SpineHelper
{
    public class ConnectionManager
    {
        private class ConnectionPort : IEquatable<ConnectionPort>
        {
            public readonly int index;
            public readonly string name;
            public string fullName;

            public ConnectionPort(int index, string name)
            {
                this.index = index;
                this.name = name;
                this.fullName = name;
            }

            public bool Equals(ConnectionPort other)
            {
                return this.name == other.name;
            }

            public override int GetHashCode()
            {
                return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
            }
        }

        public static readonly string[] ChipDeviceNames = { "", "/BT" };
        public static readonly string[] ChipNames = { "CH340", "CP210x" };
        public static string DisplayedUSBName { get { return GlobalStrings.ConnectionUSBName; } }

        public static readonly ConnectionManager instance = new ConnectionManager();

        public string PortName { get { return port.PortName; } }
        public string USBName { get; private set; }
        public string ChipName { get; private set; }

        public DeviceState DeviceConnectionState { get; private set; }

        public event Action<DeviceState> DeviceStateChanged;
        public event Action<string> DataRecieved;
        public event Action<string[], int> AvailablePortsChanged;
        public event Action ConnectionRequest;

        private SerialPort port;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private HashSet<string> availablePortNames = new HashSet<string>();
        private List<ConnectionPort> availablePorts = new List<ConnectionPort>();
        private int awaitingDeviceConfirmation = -1;




        static ConnectionManager()
        {
        }

        private ConnectionManager()
        {
            port = new SerialPort();
            port.BaudRate = 9600;
            port.DtrEnable = true;
            port.DataReceived += OnDataReceived;
            timer.Interval = 3000;
            timer.Tick += OnTimerTick;
            timer.Start();

            DeviceConnectionState = DeviceState.NotConnected;
        }

        public void SetConnectionState(DeviceState state)
        {

            if (state == DeviceState.ConnectionAttempt)
                awaitingDeviceConfirmation = 1;

            DeviceConnectionState = state;
            DeviceStateChanged?.Invoke(DeviceConnectionState);
        }

        public void RequestConnection()
        {
            ConnectionRequest?.Invoke();
        }

        public void TryConnect(int portIndex)
        {
            try
            {
                var selectedPort = availablePorts.First((p) => p.index == portIndex);
                port.PortName = selectedPort.name;
                port.Open();
                SetConnectionState(DeviceState.ConnectionAttempt);
                USBName = selectedPort.fullName;
                ChipName = GetChipNameFromPortName(selectedPort.fullName);
                Send(DeviceCodes.DEVICE_CODE_HANDSHAKE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    GlobalStrings.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                SetConnectionState(DeviceState.NotConnected);
                USBName = string.Empty;
                ChipName = string.Empty;
            }
        }

        public void Disconnect()
        {
            port.Close();
            USBName = string.Empty;
            ChipName = string.Empty;
            SetConnectionState(DeviceState.NotConnected);
        }

        public void Send(string data)
        {
            try
            {
                if (port.IsOpen) 
                    port.Write(data);
            }
            catch (Exception ex) //IO exception
            {
                MessageBox.Show(
                    ex.Message,
                    GlobalStrings.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CheckAvailablePorts()
        {
            if (port.IsOpen)
            {
                if (DeviceConnectionState == DeviceState.ConnectionAttempt && awaitingDeviceConfirmation < 0)
                {
                    Disconnect();
                }
                else
                {
                    if (DeviceConnectionState == DeviceState.ConnectionAttempt)
                        awaitingDeviceConfirmation--;
                    return;
                }
            }

            if (DeviceConnectionState > DeviceState.ConnectionAttempt)
                Disconnect();


            var newPorts = new HashSet<string>(SerialPort.GetPortNames());

            if (availablePortNames.SetEquals(newPorts))
                return;

            var changedPorts = newPorts.Except(availablePortNames);
            string newPortName = string.Empty;
            if (changedPorts.Count() > 0 && newPorts.Contains(changedPorts.First()))
                newPortName = changedPorts.First();

            availablePortNames = newPorts;

            // Do this only when ports change to prevent UI blocking
            availablePorts = GetFullCOMData(availablePortNames);
            AvailablePortsChanged?.Invoke(AvailablePortNames, GetNewPortIndexByPortName(availablePortNames, newPortName));
        }

        public string[] AvailablePortNames
        {
            get
            {
                string[] names = new string[availablePorts.Count];
                int index = 0;
                foreach (var p in availablePorts)
                {
                    names[index++] = p.fullName;
                }
                return names;
            }
        }

        private int GetNewPortIndexByPortName(IEnumerable<string> portNames, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return -1;

            int index = 0;
            foreach (var p in portNames)
            {
                if (p.Equals(name))
                    return index;
                index++;
            }
            return -1;
        }



        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                DataRecieved?.Invoke((sender as SerialPort).ReadLine());
            }
            catch (Exception ex)
            {
                if (Settings.DebugMode)
                    MessageBox.Show(GlobalStrings.DebugModeInfo +
                        "Critical error on serial port data recieved\n\nError:" + ex.Message,
                        "Critical Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            CheckAvailablePorts(); //TODO: do not use timer, make it on button click
        }



        private List<ConnectionPort> GetFullCOMData(HashSet<string> ports)
        {
            ManagementClass processClass = new ManagementClass("Win32_PnPEntity");
            ManagementObjectCollection Ports = processClass.GetInstances();

            var portSet = new List<ConnectionPort>();
            int index = 0;
            foreach (var port in ports)
            {
                portSet.Add(new ConnectionPort(index++, port));
            }

            foreach (ManagementObject property in Ports)
            {
                if (property.GetPropertyValue("Name") != null)
                {
                    string name = property.GetPropertyValue("Name").ToString();

                    for (int i = 0; i < ChipNames.Length; i++)
                    {
                        if (name.Contains(ChipNames[i]) && name.Contains("USB"))
                        {
                            for (int j = portSet.Count - 1; j >= 0; j--)
                            {
                                var p = portSet[j];
                                if (name.Contains(p.name))
                                {
                                    p.fullName = DisplayedUSBName + ChipDeviceNames[i]
                                        + GlobalStrings.ConnectionUSBNameAt + p.name;
                                    break;
                                }
                            }
                        }
                    }
                }

            }
            return portSet;
        }

        private string GetChipNameFromPortName(string name)
        {
            for (int i = ChipDeviceNames.Length - 1; i >= 0; i--)
            {
                if (name.Contains(ChipDeviceNames[i]) && ChipNames.Length > i)
                    return ChipNames[i];
            }
            return "----";
        }
    }

}
