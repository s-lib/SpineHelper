using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SpineHelper.Device;

namespace SpineHelper.View.Calibration
{
    public partial class CalibrationWeightUC : TimeUpdatedUC
    {
        public double AverageValue { get { return GetAverage(); } }
        public bool IsCalibrationActive { get; private set; } = false;

        private List<double> calibrationValues = new List<double>();


        public CalibrationWeightUC()
        {
            InitializeComponent();

            radioInput1.Checked = true;
            radioLeftSensor.Checked = true;

            SwitchInputValues(radioInput1.Checked);
            UpdateCalibrationInfo();
        }

        protected override void OnUpdateControls(DeviceState state)
        {
            if (IsCalibrationActive && state == DeviceState.WeightCalibration)
            {
                double value = radioRightSensor.Checked ?
                    Spinetester.instance.TensionSaved.Right :
                    Spinetester.instance.TensionSaved.Left;

                if (radioInput2.Checked)
                {
                    value /= (double)numericInput2.Value;
                }
                else
                {
                    value /= (double)numericInput1.Value * 15.4323584;
                }

                AddCalibrationValue(value);
                UpdateCalibrationValue(AverageValue);
            }

            if (state == DeviceState.Scaled)
            {
                UpdateCalibrationInfo();
            }
        }



        private void radioInput1_CheckedChanged(object sender, EventArgs e)
        {
            SwitchInputValues(radioInput1.Checked);
            ClearCalibrationValues();
        }

        private void radioInput2_CheckedChanged(object sender, EventArgs e)
        {
            SwitchInputValues(!radioInput2.Checked);
            ClearCalibrationValues();
        }

        private void radioLeftSensor_CheckedChanged(object sender, EventArgs e)
        {
            ClearCalibrationValues();
        }

        private void radioRightSensor_CheckedChanged(object sender, EventArgs e)
        {
            ClearCalibrationValues();
        }
        
        private void buttonCalibrate_Click(object sender, EventArgs e)
        {
            SetCalibrationState(!IsCalibrationActive);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearCalibrationValues();
            SetNumericValue(numericCalibration, 1);
            ConnectionManager.instance.Send(DeviceCodes.DEVICE_CODE_TARE);

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            bool left = radioLeftSensor.Checked;
            double value = (double)numericCalibration.Value;
            int valueToSend = Convert.ToInt32(Math.Round(value * 100.0, 0));

            string valueString = (valueToSend * 0.01).ToString();
            string sensorString = left ? GlobalStrings.CalibrationLeftUpper : GlobalStrings.CalibrationRightUpper;

            var dr = MessageBox.Show(
                string.Format(GlobalStrings.CalibrationApplySensor, sensorString, valueString),
                GlobalStrings.CalibrationApplyHeader,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string c = left ? DeviceCodes.DEVICE_CODE_CALIBRATE_LEFT : DeviceCodes.DEVICE_CODE_CALIBRATE_RIGHT;
                ConnectionManager.instance.Send(c + valueToSend.ToString());
            }
        }




        private void SwitchInputValues(bool gramsEnabled)
        {
            SetEnabled(numericInput1, gramsEnabled);
            SetEnabled(numericInput2, !gramsEnabled);
        }


        private void UpdateCalibrationInfo()
        {
            SetText(labelCurrentL, Spinetester.instance.Settings.ScaleLeft.ToString("0.00"));
            SetText(labelFactoryL, Spinetester.instance.Factory.ScaleLeft.ToString("0.00"));

            SetText(labelCurrentR, Spinetester.instance.Settings.ScaleRight.ToString("0.00"));
            SetText(labelFactoryR, Spinetester.instance.Factory.ScaleRight.ToString("0.00"));
        }

        private void SetCalibrationState(bool isActive)
        {
            IsCalibrationActive = isActive;

            SetText(buttonCalibrate, isActive ? GlobalStrings.CalibrationStop : GlobalStrings.CalibrationBegin);
            SetEnabled(numericCalibration, isActive ? false : true);
            buttonCalibrate.ForeColor = isActive ? Color.Red : Color.Black;

            SetEnabled(buttonReset, !isActive);
            SetEnabled(buttonApply, !isActive);

            SetEnabled(radioInput1, !isActive);
            SetEnabled(radioInput2, !isActive);
            if (!isActive)
            {
                SwitchInputValues(radioInput1.Checked);
                UpdateCalibrationValue(AverageValue);
            }
            else
            {
                SetEnabled(numericInput1, false);
                SetEnabled(numericInput2, false);
            }

            SetEnabled(radioLeftSensor, !isActive);
            SetEnabled(radioRightSensor, !isActive);
        }


        private double GetAverage()
        {
            if (calibrationValues == null || calibrationValues.Count == 0)
            {
                return 1;
            }
            else
            {
                return calibrationValues.Average();
            }
        }


        public void StopCalibration()
        {
            if (IsCalibrationActive)
                SetCalibrationState(false);
        }

        public void AddCalibrationValue(double value)
        {
            calibrationValues.Add(value);
            UpdateLastReading(value);
        }

        public void ClearCalibrationValues()
        {
            calibrationValues.Clear();
            SetText(labelReadingsValue, Common.NoData);
            SetText(labelNumReadings, Common.NoData);
            ChangeLabelColor(labelNumReadings, calibrationValues.Count);
        }

        public void UpdateCalibrationValue(double value)
        {
            SetNumericValue(numericCalibration, (decimal)value);
        }

        private void SetNumericValue(NumericUpDown num, decimal value)
        {
            if (SafeControlStateChange(SetNumericValue, num, value))
            {
                num.Value = Math.Min(Math.Max(value, num.Minimum), num.Maximum);
            }
        }

        private void UpdateLastReading(double value)
        {
            SetText(labelReadingsValue, value.ToString());
            SetText(labelNumReadings, calibrationValues.Count.ToString());
            ChangeLabelColor(labelNumReadings, calibrationValues.Count);
        }

        private void ChangeLabelColor(Label label, int value)
        {
            if (SafeControlStateChange(ChangeLabelColor, label, value))
            {
                Color color = Color.Black;
                if (value >= 25)
                    color = Color.Green;
                else if (value >= 15)
                    color = Color.DarkOrange;
                else if (value > 0)
                    color = Color.Red;

                label.ForeColor = color;
            }
        }

    }
}
