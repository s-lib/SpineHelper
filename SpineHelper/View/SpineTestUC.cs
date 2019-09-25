using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SpineHelper.Data;
using SpineHelper.Device;

namespace SpineHelper.View
{
    public partial class SpineTestUC : TimeUpdatedUC
    {
        public bool MultiSpineAllowed { get; set; } = false;

        public event Action<double> SpineTestPassed;

        private Color defaultPanelColor = Color.Black;

        private bool fullTestDone = false;
        private double previousSpineTension = 0;

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
                        SpineTestPassed?.Invoke(arrow.AllTestsDone? arrow.Spine.Value2 : arrow.Spine.Value1);
                    break;
                case DeviceState.StraightnessTestDone:
                    if (MultiSpineAllowed == false) this.BackColor = Color.DarkSeaGreen;
                    this.fullTestDone = true;
                    SetText(labelMainValue, arrow.Spine.Get(main).ToString());
                    SetText(labelSecondaryValue, arrow.Spine.Get(!main).ToString());
                    break;

                // Only for Multi Spine Testing
                case DeviceState.Tension:
                    if (MultiSpineAllowed && fullTestDone)
                    {
                        double rawSpine = 0;
                        if (Spinetester.instance.Tension.Total > 1500)
                        {
                            rawSpine = Spinetester.instance.GetRawSpineFromTension(Spinetester.instance.SpineTension);

                            if (Spinetester.instance.RawSpineDifferencePassed(previousSpineTension))
                            {
                                this.BackColor = Color.SkyBlue;
                                // Trigger an event for multi spine test
                                SpineTestPassed?.Invoke(rawSpine);
                                previousSpineTension = 100000;
                            }
                            else
                            {
                                this.BackColor = defaultPanelColor;
                                previousSpineTension = Spinetester.instance.SpineTension;
                            }
                        }

                        string[] spine = new string[] { Common.NoData, Common.NoData } ;
                        if (rawSpine > 0)
                        {
                            spine[0] = UnitsConverter.ToASTM(rawSpine).ToString();
                            spine[1] = UnitsConverter.ToAMO(rawSpine).ToString();
                        }

                        SetText(labelMainValue, spine[Convert.ToInt32(main)]);
                        SetText(labelSecondaryValue, spine[Convert.ToInt32(!main)]);
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
