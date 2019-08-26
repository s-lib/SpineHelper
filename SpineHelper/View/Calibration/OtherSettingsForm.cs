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
            numericVolume.Value = Spinetester.instance.Settings.SpeakerVolume;
            trackBarVolume.Value = Spinetester.instance.Settings.SpeakerVolume;

            for (int i = 0; i < Spinetester.instance.Factory.Language; i++)
            {
                comboBoxLanguage.Items.Add(DeviceSettings.GetLanguageName(i));
            }
            comboBoxLanguage.SelectedIndex = Spinetester.instance.Settings.Language;
            comboBoxLanguage.Enabled = true;

            labelAmpCurrentVal.Text = Spinetester.instance.Settings.HX711Frequency.ToString();
            labelAmpFactoryVal.Text = Spinetester.instance.Factory.HX711Frequency.ToString();

            labelSpThCurrentVal.Text = Spinetester.instance.Settings.SpineDifference.ToString();
            labelSpThFactoryVal.Text = Spinetester.instance.Factory.SpineDifference.ToString();


            labelVolumeCurrentVal.Text = Spinetester.instance.Settings.SpeakerVolume.ToString();
            labelVolumeFactoryVal.Text = Spinetester.instance.Factory.SpeakerVolume.ToString();

            labelLanguageCurrentVal.Text = DeviceSettings.GetLanguageName(Spinetester.instance.Settings.Language);
            labelLanguageFactoryVal.Text = DeviceSettings.GetLanguageName(0);


            if (Spinetester.instance.Factory.SpeakerVolume == 0)
            {
                buttonApplyVolume.Enabled = false;
                numericVolume.Enabled = false;
            }


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

        private void buttonApplyVolume_Click(object sender, EventArgs e)
        {
            int value = trackBarVolume.Value;

            string message = string.Format(GlobalStrings.CalibrationApplyVolume,
                Spinetester.instance.Settings.SpeakerVolume.ToString(), value.ToString("0"));

            ApplyToDevice(DeviceCodes.DEVICE_CODE_ADJUST_SPEAKER_VOL, value, false, message);
        }

        private void buttonApplyLanguage_Click(object sender, EventArgs e)
        {
            int value = comboBoxLanguage.SelectedIndex;

            string message = string.Format(GlobalStrings.CalibrationApplyLanguage,
                DeviceSettings.GetLanguageName(Spinetester.instance.Settings.Language),
                DeviceSettings.GetLanguageName(value));

            ApplyToDevice(DeviceCodes.DEVICE_CODE_ADJUST_LANGUAGE, value, false, message);
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



        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            numericVolume.Value = ((TrackBar)sender).Value;
        }

        private void numericVolume_ValueChanged(object sender, EventArgs e)
        {
            trackBarVolume.Value = (int)((NumericUpDown)sender).Value;
        }
    }
}
