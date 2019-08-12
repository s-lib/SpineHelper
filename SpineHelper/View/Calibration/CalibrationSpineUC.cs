using System;
using System.Windows.Forms;
using SpineHelper.Device;
using SpineHelper.Data;

namespace SpineHelper.View.Calibration
{
    public partial class CalibrationSpineUC : TimeUpdatedUC
    {
        private const double MinMeasuringDistance = 5.0;
        private const double MaxMeasuringDistance = 15.0;


        public CalibrationSpineUC()
        {
            InitializeComponent();

            radioInput1.Checked = true;

            SwitchInputValues(radioInput1.Checked);
            UpdateCalibrationInfo();
        }

        protected override void OnUpdateControls(DeviceState state)
        {
            if (state == DeviceState.Scaled || state == DeviceState.StraightnessTestDone)
            {
                UpdateCalibrationInfo();
            }
        }


        private void radioInput1_CheckedChanged(object sender, EventArgs e)
        {
            SwitchInputValues(radioInput1.Checked);
        }

        private void radioInput2_CheckedChanged(object sender, EventArgs e)
        {
            SwitchInputValues(!radioInput2.Checked);
        }

        private void SwitchInputValues(bool gramsEnabled)
        {
            SetEnabled(numericInput1, gramsEnabled);
            SetEnabled(numericInput2, !gramsEnabled);
        }



        private void UpdateCalibrationInfo()
        {
            SetText(labelCurrentL, Spinetester.instance.Settings.FixedDeflection.ToString("0.00"));
            SetText(labelFactoryL, Spinetester.instance.Factory.FixedDeflection.ToString("0.00"));


            SetNumericValue(numericCalibration, (decimal)Spinetester.instance.Settings.FixedDeflection);

            var arrow = Spinetester.instance.CurrentArrow;

            SetNumericValue(numericLastASTM, (decimal)arrow.Spine.ASTM);
            SetNumericValue(numericLastAMO, (decimal)arrow.Spine.Value);
            SetNumericValue(numericLastTension, (decimal)arrow.Spine.Raw);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            double value = (double)numericCalibration.Value;
            int valueToSend = Convert.ToInt32(Math.Round(value * 100.0, 0));

            string oldValue = Spinetester.instance.Settings.FixedDeflection.ToString("0.00");
            string newValue = (valueToSend * 0.01).ToString();

            var dr = MessageBox.Show(
                string.Format(GlobalStrings.CalibrationApplySpine, oldValue, newValue),
                GlobalStrings.CalibrationApplyHeader,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string c = DeviceCodes.DEVICE_CODE_CALIBRATE_SPINE;
                ConnectionManager.instance.Send(c + valueToSend.ToString());
            }
        }




        private void buttonCalibrate_Click(object sender, EventArgs e)
        {
            CalculateFixedDeflection();
        }





        private void CalculateFixedDeflection()
        {
            double desiredSpineAMO = radioInput2.Checked ?
                (double)numericInput2.Value :
                UnitsConverter.ASTMtoAMO((double)numericInput1.Value);

            double rawTension = Spinetester.instance.CurrentArrow.Spine.Raw;

            //double tension = 6750.87 * 0.06479891 / 1000.0; //* 0.00006479891

            // 5-15mm range
            double closestDeflection = 10.0;

            //for (double i = 1.0; i >= 0.01; i *= 0.1)
            //    closestDeflection = FindSpineClosestDeflection(tension, desiredSpineAMO, closestDeflection, i);

            // First pass 1.0
            closestDeflection = FindSpineClosestDeflection(rawTension, desiredSpineAMO, closestDeflection, 1.0);

            // Second pass 0.1
            closestDeflection = FindSpineClosestDeflection(rawTension, desiredSpineAMO, closestDeflection, 0.1);

            // Third pass 0.01
            closestDeflection = FindSpineClosestDeflection(rawTension, desiredSpineAMO, closestDeflection, 0.01);
            

            SetNumericValue(numericCalibration, (decimal)closestDeflection);
        }

        private void SetNumericValue(NumericUpDown num, decimal value)
        {
            if (SafeControlStateChange(SetNumericValue, num, value))
            {
                num.Value = value;
            }
        }


        private double FindSpineClosestDeflection(double rawTension, double spine, double start, double increment)
        {

            double range = increment * 10.0;
            double end = start + (range * 0.5);
            double begin = start - (range * 0.5);

            if (start < 0.1)
                start = 0.1;

            double closestDeflection = 0;
            double closestDifference = 1000;

            for (double i = begin; i < end; i += increment)
            {
                double currentSpineAMO = SpineCalculator.GetSpineAMO(rawTension, i);

                double difference = Math.Abs(spine - currentSpineAMO);

                if (difference < closestDifference)
                {
                    closestDifference = difference;
                    closestDeflection = i;
                }
            }

            return closestDeflection == 0 ? start : closestDeflection;
        }


    }
}
