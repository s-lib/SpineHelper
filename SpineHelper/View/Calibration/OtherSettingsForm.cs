using SpineHelper.Device;
using System;
using System.Windows.Forms;

namespace SpineHelper.View.Calibration
{
    public partial class OtherSettingsForm : Form
    {
        public OtherSettingsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            InitializeControls();
        }

        private void InitializeControls()
        {
            numericSpine.Value = (decimal)Spinetester.instance.Settings.SpineDifference;
            numericAmp.Value = Spinetester.instance.Settings.HX711Frequency;

            labelAmpCurrentVal.Text = Spinetester.instance.Settings.HX711Frequency.ToString();
            labelAmpFactoryVal.Text = Spinetester.instance.Factory.HX711Frequency.ToString();

            labelSpThCurrentVal.Text = Spinetester.instance.Settings.SpineDifference.ToString();
            labelSpThFactoryVal.Text = Spinetester.instance.Factory.SpineDifference.ToString();

            var t = toolTip1.GetToolTip(groupBoxSpineDiff);
            foreach(Control c in groupBoxSpineDiff.Controls)
            {
                toolTip1.SetToolTip(c, t);
            }

            t = toolTip1.GetToolTip(groupBoxAmp);
            foreach (Control c in groupBoxAmp.Controls)
            {
                toolTip1.SetToolTip(c, t);
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonApplySpine_Click(object sender, EventArgs e)
        {
            double value = (double)numericSpine.Value;

            string message = string.Format(GlobalStrings.CalibrationApplySpineDiff,
                Spinetester.instance.Settings.SpineDifference.ToString("0.0"), value.ToString("0.0"));

            ApplyToDevice(DeviceCodes.DEVICE_CODE_CALIBRATE_SPINE_DIFF, value, true, message);
        }

        private void buttonApplyAmp_Click(object sender, EventArgs e)
        {
            double value = (double)numericAmp.Value;

            string message = string.Format(GlobalStrings.CalibrationApplyHX711,
                Spinetester.instance.Settings.HX711Frequency.ToString(), value.ToString("0"));

            ApplyToDevice(DeviceCodes.DEVICE_CODE_CALIBRATE_HX711, value, false, message);
        }



        private void ApplyToDevice(string code, double value, bool isFloat, string message)
        {
            value = isFloat ? value * 100.0 : value;
            int valueToSend = Convert.ToInt32(Math.Round(value, 0));

            var dr = MessageBox.Show(
                message,
                GlobalStrings.CalibrationApplyHeader,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                ConnectionManager.instance.Send(code + valueToSend.ToString());
            }
        }
    }
}
