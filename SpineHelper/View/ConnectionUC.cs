using System;
using System.Drawing;
using SpineHelper.Device;
using SpineHelper.Data;

namespace SpineHelper.View
{
    public partial class ConnectionUC : TimeUpdatedUC
    {
        private const int TimerDelay = 15;
        private int COMtimer = 0;
        private string[] availablePorts = new string[0];

        public ConnectionUC()
        {
            InitializeComponent();
            ConnectionManager.instance.AvailablePortsChanged += OnAvailablePortsChanged;
            ConnectionManager.instance.ConnectionRequest += OnConnectionRequest;

            SwitchConnectionPanel(ConnectionManager.instance.DeviceConnectionState >= DeviceState.Connected);
            OnUpdateControls(ConnectionManager.instance.DeviceConnectionState);
            buttonConnect.Enabled = false;
        }


        protected override void OnTimedUpdate() //TODO: take tension from event
        {
            base.OnTimedUpdate();

            if (COMtimer > 0)
            {
                if (--COMtimer == 0)
                {
                    SetVisibility(labelCOMfound, false);
                }
            }

            string format = Settings.DebugMode ? "0.00" : "0.0";
            SetText(labelTension, UnitsConverter.GrainsToGrams(Spinetester.instance.Tension.Total).ToString(format));
        }


        protected override void OnUpdateControls(DeviceState state)
        {
            switch (state)
            {
                case DeviceState.NotConnected:
                    SetText(labelConnect, GlobalStrings.DeviceNotConnected);
                    labelConnect.ForeColor = Color.Red;
                    SwitchConnectionPanel(false);
                    break;
                case DeviceState.ConnectionAttempt:
                    SetText(labelConnect, GlobalStrings.DeviceConnecting);
                    labelConnect.ForeColor = Color.Blue;
                    break;
                case DeviceState.Connected:
                    SetText(labelConnect, GlobalStrings.DeviceConnected);
                    SetText(labelCommand, GlobalStrings.DeviceCommandWait);
                    SwitchConnectionPanel(true);
                    break;
                case DeviceState.Ready:
                    labelConnect.ForeColor = Color.Green;
                    SetButtonImage(buttonDisconnect, Properties.Resources.dot_green);
                    SetText(labelConnect, Settings.SimplifiedConnectionInfo ?
                        GlobalStrings.DeviceConnected :
                        GlobalStrings.DeviceIsReady);
                    break;
                case DeviceState.Reset:
                    if (Settings.SimplifiedConnectionInfo)
                    {
                        SetText(labelConnect, string.Empty);
                        SetText(labelCommand, string.Empty);
                    }
                    break;
                default:
                    break;
            }

            if (Settings.SimplifiedConnectionInfo == false)
            {
                switch (state)
                {
                    //case DeviceState.Connected:
                    //    SetText(labelCommand, GlobalStrings.DeviceCommandWait);
                    //    break;
                    case DeviceState.Tared:
                        break;
                    case DeviceState.Reset:
                        SetText(labelConnect, GlobalStrings.DeviceIsReady);
                        SetText(labelCommand, GlobalStrings.DeviceCommandReady);
                        break;
                    case DeviceState.Tension:
                        break;
                    case DeviceState.WeightCalibration:
                        SetText(labelConnect, GlobalStrings.DeviceWeightCalibration);
                        SetText(labelCommand, GlobalStrings.DeviceCommandWait);
                        break;
                    case DeviceState.WeightTest:
                        SetText(labelConnect, GlobalStrings.DeviceWeightTest);
                        SetText(labelCommand, GlobalStrings.DeviceCommandWait);
                        break;
                    case DeviceState.WeightTestDone:
                        SetText(labelConnect, GlobalStrings.DeviceWeightTestDone);
                        SetText(labelCommand, GlobalStrings.DeviceCommandTestSpine);
                        break;
                    case DeviceState.SpineTest:
                        SetText(labelConnect, Spinetester.instance.CurrentArrow.BasicTestDone ?
                            GlobalStrings.DeviceSpine2Test :
                            GlobalStrings.DeviceSpine1Test);
                        SetText(labelCommand, GlobalStrings.DeviceCommandWait);
                        break;
                    case DeviceState.SpineTestDone:
                        SetText(labelConnect, Spinetester.instance.CurrentArrow.AllTestsDone ?
                            GlobalStrings.DeviceSpine2TestDone :
                            GlobalStrings.DeviceSpine1TestDone);
                        SetText(labelCommand, Spinetester.instance.CurrentArrow.AllTestsDone ? 
                            GlobalStrings.DeviceCommandWait :
                            GlobalStrings.DeviceCommandTestSpine2);
                        break;
                    case DeviceState.StraightnessTestDone:
                        SetText(labelConnect, GlobalStrings.DeviceStraightness);
                        SetText(labelCommand, GlobalStrings.DeviceCommandAllDone);
                        break;
                    default:
                        break;
                    }
                }
        }

        private void SwitchConnectionPanel(bool connected)
        {
            if (connected)
            {
                labelConnect.ForeColor = Color.DarkOrange;
                SetPanelVisibility(panelConnection, false);
                SetButtonImage(buttonDisconnect, Properties.Resources.dot_orange);
            }
            else
            {
                SetPanelVisibility(panelConnection, true);
                ShowAvaliablePortData(availablePorts, false);
                SetText(labelCommand, string.Empty);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            OnConnectionRequest();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            ConnectionManager.instance.Disconnect();
        }

        private void buttonTare_Click(object sender, EventArgs e)
        {
            ConnectionManager.instance.Send(DeviceCodes.DEVICE_CODE_TARE);
        }

        private void OnConnectionRequest()
        {
            if (comboBoxComPort.SelectedIndex < 0) return;

            SetEnabled(buttonConnect, false);
            ConnectionManager.instance.TryConnect(comboBoxComPort.SelectedIndex);
        }

        private void OnAvailablePortsChanged(string[] ports)
        {
            ShowAvaliablePortData(ports, true);
        }

        private void ShowAvaliablePortData(string[] ports, bool rescaned)
        {
            availablePorts = ports;
            comboBoxComPort.Items.Clear();
            comboBoxComPort.Items.AddRange(availablePorts);

            if (availablePorts.Length > 0)
            {
                COMtimer = TimerDelay;
                int selected = -1;
                for (int i = 0; i < availablePorts.Length; i++)
                {
                    if (availablePorts[i].Contains(ConnectionManager.DisplayedUSBName))
                    {
                        selected = i;
                        COMtimer *= 2;
                        break;
                    }
                }

                if (selected >= 0 || rescaned)
                    SetVisibility(labelCOMfound, true);

                comboBoxComPort.SelectedIndex = selected >= 0 ? selected : availablePorts.Length - 1;
                labelCOMfound.ForeColor = selected >= 0 ? Color.LawnGreen : Color.Brown;
                labelCOMfound.BackColor = selected >= 0 ? Color.DarkGreen : Color.DarkOrange;
                SetText(labelCOMfound, selected >= 0 ?
                    string.Format(GlobalStrings.ConnectFound, availablePorts[selected]) : GlobalStrings.ConnectFoundPort);

                SetEnabled(buttonConnect, true);
            }
            else
            {
                SetVisibility(labelCOMfound, false);
                SetEnabled(buttonConnect, false);
            }
        }


    }
}
