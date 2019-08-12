using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SpineHelper.Device;

namespace SpineHelper.View
{
    public partial class SpineTestUC : TimeUpdatedUC
    {
        private Color defaultPanelColor = Color.Black;

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
                    break;
                case DeviceState.StraightnessTestDone:
                    this.BackColor = Color.DarkSeaGreen;
                    SetText(labelMainValue, arrow.Spine.Get(main).ToString());
                    SetText(labelSecondaryValue, arrow.Spine.Get(!main).ToString());
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
