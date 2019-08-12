using SpineHelper.Device;

namespace SpineHelper.View
{
    public partial class SpineDetailsUC : TimeUpdatedUC
    {
        public SpineDetailsUC()
        {
            InitializeComponent();
            GlobalEventManager.instance.SpineUnitsSwitched += UpdateLabelValues;
        }

        protected override void OnUpdateControls(DeviceState state)
        {
            var arrow = Spinetester.instance.CurrentArrow;

            switch (state)
            {
                case DeviceState.Reset:
                    SetText(labelSpine1, Common.NoData);
                    SetText(labelSpine1sd, Common.NoData);
                    SetText(labelSpine2, Common.NoData);
                    SetText(labelSpine2sd, Common.NoData);
                    SetText(labelStraightness, Common.NoData);
                    SetText(labelStraightness2, Common.NoData);
                    break;
                case DeviceState.SpineTestDone:
                    UpdateLabelValues();
                    break;
                case DeviceState.StraightnessTestDone:
                    SetText(labelStraightness, arrow.Straightness.String);
                    SetText(labelStraightness2, arrow.Straightness.GradeString);
                    break;
                default:
                    break;
            }
        }


        private void UpdateLabelValues()
        {
            var arrow = Spinetester.instance.CurrentArrow;
            bool main = Settings.SpineAMO;

            if (arrow.AllTestsDone)
            {
                SetText(labelSpine2, arrow.Spine.Get(main, 2).ToString());
                SetText(labelSpine2sd, arrow.Spine.Get(!main, 2).ToString());
            }
            if (arrow.BasicTestDone)
            {
                SetText(labelSpine1, arrow.Spine.Get(main, 1).ToString());
                SetText(labelSpine1sd, arrow.Spine.Get(!main, 1).ToString());
            }
        }

    }
}
