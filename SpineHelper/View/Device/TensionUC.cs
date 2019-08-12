using SpineHelper.Device;
using SpineHelper.Data;

namespace SpineHelper.View.Device
{
    public partial class TensionUC : TimeUpdatedUC
    {
        public TensionUC()
        {
            InitializeComponent();
        }


        protected override void OnTimedUpdate()
        {
            base.OnTimedUpdate();

            SetText(labelGrainsL, Spinetester.instance.Tension.Left.ToString("0.0"));
            SetText(labelGrainsR, Spinetester.instance.Tension.Right.ToString("0.0"));
            SetText(labelGrainsVal, Spinetester.instance.Tension.Total.ToString("0.0"));

            SetText(labelGramsL, UnitsConverter.GrainsToGrams(Spinetester.instance.Tension.Left).ToString("0.0"));
            SetText(labelGramsR, UnitsConverter.GrainsToGrams(Spinetester.instance.Tension.Right).ToString("0.0"));
            SetText(labelGramsVal, UnitsConverter.GrainsToGrams(Spinetester.instance.Tension.Total).ToString("0.0"));

        }

        protected override void OnUpdateControls(DeviceState state)
        {
        }
    }
}
