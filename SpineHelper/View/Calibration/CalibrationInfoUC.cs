using SpineHelper.Device;

namespace SpineHelper.View.Calibration
{
    public partial class CalibrationInfoUC : TimeUpdatedUC
    {

        public CalibrationInfoUC()
        {
            InitializeComponent();

            UpdateCalibrationInfo();
        }

        protected override void OnUpdateControls(DeviceState state)
        {
            if (state == DeviceState.Scaled)
            {
                UpdateCalibrationInfo();
            }
        }

        private void UpdateCalibrationInfo()
        {
            // Weight left
            SetText(labelCurrentL, Spinetester.instance.Settings.ScaleLeft.ToString("0.00"));
            SetText(labelFactoryL, Spinetester.instance.Factory.ScaleLeft.ToString("0.00"));

            // Weight right
            SetText(labelCurrentR, Spinetester.instance.Settings.ScaleRight.ToString("0.00"));
            SetText(labelFactoryR, Spinetester.instance.Factory.ScaleRight.ToString("0.00"));

            // Spine
            SetText(labelCurrentSpineVal, Spinetester.instance.Settings.FixedDeflection.ToString("0.00"));
            SetText(labelFactorySpineVal, Spinetester.instance.Factory.FixedDeflection.ToString("0.00"));
        }

    }
}
