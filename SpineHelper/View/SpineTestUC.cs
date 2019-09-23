using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SpineHelper.Device;

namespace SpineHelper.View
{
    [Serializable]
    public partial class SpineTestUC : TimeUpdatedUC
    {
        [Category("Data")]
        public bool MultiSpineAllowed { get; set; } = false;

        public event Action<double> SpineTestPassed;

        private Color defaultPanelColor = Color.Black;

        private bool fullTestDone = false;
        private double previousTension = 0;

        public SpineTestUC()
        {
            InitializeComponent();
            defaultPanelColor = this.BackColor;
            SwitchLabels();

            RegisterClickEvent(this);
            foreach (var c in this.Controls.OfType<Control>())
            {
                RegisterClickEvent(c);
            }
            GlobalEventManager.instance.SpineUnitsSwitched += OnSpineUnitsSwitched;
        }

        protected override void OnUpdateControls(DeviceState state)
        {
            var arrow = Spinetester.instance.CurrentArrow;
            var device = Spinetester.instance;
            bool main = Settings.SpineAMO;

            switch (state)
            {
                case DeviceState.Reset:
                    this.BackColor = defaultPanelColor;
                    this.fullTestDone = false;
                    SetText(labelMainValue,
                        arrow.BasicTestDone ? arrow.Spine.Get(main).ToString() : Common.NoData);
                    SetText(labelSecondaryValue,
                        arrow.BasicTestDone ? arrow.Spine.Get(!main).ToString() : Common.NoData);
                    break;
                case DeviceState.SpineTest:
                    this.BackColor = defaultPanelColor;
                    SetText(labelMainValue, arrow.GetTestedSpine(main).ToString());
                    SetText(labelSecondaryValue, arrow.GetTestedSpine(!main).ToString());
                    break;
                case DeviceState.SpineTestDone:
                    this.BackColor = Color.SkyBlue;
                    if (arrow.AllTestsDone)
                    {
                        SetText(labelMainValue, arrow.Spine.Get(main, 2).ToString());
                        SetText(labelSecondaryValue, arrow.Spine.Get(!main, 2).ToString());
                    }
                    else
                    {
                        SetText(labelMainValue, arrow.Spine.Get(main, 1).ToString());
                        SetText(labelSecondaryValue, arrow.Spine.Get(!main, 1).ToString());
                    }
                    // Trigger an event for multi spine test
                    if (MultiSpineAllowed)
                        SpineTestPassed?.Invoke(arrow.Spine.Get(Settings.SpineAMO, arrow.AllTestsDone? 2 : 1));
                    break;
                case DeviceState.StraightnessTestDone:
                    if (MultiSpineAllowed == false) this.BackColor = Color.DarkSeaGreen;
                    this.fullTestDone = true;
                    SetText(labelMainValue, arrow.Spine.Get(main).ToString());
                    SetText(labelSecondaryValue, arrow.Spine.Get(!main).ToString());
                    break;

                case DeviceState.Tension:
                    if (MultiSpineAllowed && fullTestDone)
                    {
                        ////TODO: spine difff pass
                        //if (Spinetester.instance.RawSpineDifferencePassed(previousTension))
                        //{
                        //    previousTension = Spinetester.instance.Tension.Total;
                        //    // Trigger an event for multi spine test
                        //    SpineTestPassed?.Invoke(arrow.Spine.Value);
                        //}
                    }
                    break;
                default:
                    break;
            }
        }

        private void SwitchLabels()
        {
            bool amo = Settings.SpineAMO;
            SetText(labelMain, amo ? GlobalStrings.AMO : GlobalStrings.ASTM);
            SetText(labelSecondary, (!amo ? GlobalStrings.AMO : GlobalStrings.ASTM) + Common.Colon);
        }
        private void SwitchLabelValues()
        {
            string t = labelMainValue.Text;
            string t2 = labelSecondaryValue.Text;

            SetText(labelMainValue, t2);
            SetText(labelSecondaryValue, t);
        }


        private void RegisterClickEvent(Control c)
        {
            c.Click += OnClick;
        }

        private void OnClick(object sender, EventArgs e)
        {
            GlobalEventManager.instance.OnSpineUnitsSwitched();
        }

        private void OnSpineUnitsSwitched()
        {
            SwitchLabels();
            SwitchLabelValues();
        }
    }

}
