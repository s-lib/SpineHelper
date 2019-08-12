using SpineHelper.Device;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpineHelper.View.Device
{
    public partial class DeviceInfoForm : Form
    {
        public DeviceInfoForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            ConnectionManager.instance.DeviceStateChanged += OnDeviceStateChanged;

            InitLabels();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!Settings.DebugMode && Spinetester.instance.Model.Firmware < 1.1)
            {
                this.Size = new Size(this.Size.Width, 400);
            }
            base.OnLoad(e);
        }

        private void InitLabels()
        {
            labelVersion.Text = labelVersion.Text + Spinetester.instance.Model.VersionString;
            // Hardware
            labelSerialVal.Text = Spinetester.instance.Model.SerialString;
            labelFirmwareVal.Text = Spinetester.instance.Model.FirmwareString;
            labelCOMVal.Text = ConnectionManager.instance.PortName;
            labelUSBChipVal.Text = ConnectionManager.ChipName;
            labelHXVal.Text = Spinetester.instance.Model.Amplifier;
            labelBluetoothVal.Text = Common.NoData;

            // Sensors
            labelCurrentL.Text = Spinetester.instance.Settings.ScaleLeft.ToString();
            labelCurrentR.Text = Spinetester.instance.Settings.ScaleRight.ToString();
            labelFactoryL.Text = Spinetester.instance.Factory.ScaleLeft.ToString();
            labelFactoryR.Text = Spinetester.instance.Factory.ScaleRight.ToString();
            // Spine
            labelCurrentSpineVal.Text = Spinetester.instance.Settings.FixedDeflection.ToString();
            labelFactorySpineVal.Text = Spinetester.instance.Factory.FixedDeflection.ToString();

            // Amplifier freq
            labelAmpCurrentVal.Text = Spinetester.instance.Settings.HX711Frequency.ToString();
            labelAmpFactoryVal.Text = Spinetester.instance.Factory.HX711Frequency.ToString();

            // Spine threashold
            labelSpThCurrentVal.Text = Spinetester.instance.Settings.SpineDifference.ToString();
            labelSpThFactoryVal.Text = Spinetester.instance.Factory.SpineDifference.ToString();

            // Speaker volume
            labelVolumeVal.Text = Spinetester.instance.Settings.SpeakerVolume.ToString();
            labelVolumeFactory.Text = Spinetester.instance.Factory.SpeakerVolume.ToString();

            // Language
            labelLanguageVal.Text = DeviceSettings.GetLanguageName(Spinetester.instance.Settings.Language);
            labelLanguageFactory.Text = DeviceSettings.GetLanguageName(0);



            if (Spinetester.instance.Model.Firmware < 1.1)
            {
                groupBoxConfiguration.Visible = false;
            }

            if (!Settings.DebugMode)
            {
                tensionUC.Visible = false;
            }
        }

        private void OnDeviceStateChanged(DeviceState state)
        {
            if (state == DeviceState.NotConnected)
                this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
