using SpineHelper.Device;
using System;
using System.Windows.Forms;

namespace SpineHelper.View.Calibration
{
    public partial class CalibrationInfoForm : Form
    {

        public CalibrationInfoForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            ConnectionManager.instance.DeviceStateChanged += OnDeviceStateChanged;

            buttonSettings.Enabled = Spinetester.instance.Model.Firmware > 1.0;
        }

        private void OnDeviceStateChanged(DeviceState state)
        {
            if (state == DeviceState.NotConnected)
                this.Close();
        }

        private void buttonResetFactory_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(
                GlobalStrings.CalibrationResetPopup,
                GlobalStrings.CalibrationResetPopupHeader,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                ConnectionManager.instance.Send(DeviceCodes.DEVICE_CODE_RESET_FACTORY);
            }
        }

        private void buttonCalibrateWeight_Click(object sender, EventArgs e)
        {
            var form = WindowManager.instance.TryOpen<CalibrationForm>() as CalibrationForm;
            form.Init(CalibrationForm.Type.Weight);
        }

        private void buttonCalibrateSpine_Click(object sender, EventArgs e)
        {
            var form = WindowManager.instance.TryOpen<CalibrationForm>() as CalibrationForm;
            form.Init(CalibrationForm.Type.Spine);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            WindowManager.instance.TryOpen<OtherSettingsForm>();
        }
    }
}
