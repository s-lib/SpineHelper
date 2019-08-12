using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SpineHelper.Device;

namespace SpineHelper.View
{
    public partial class WeightTestUC : TimeUpdatedUC
    {
        private Color defaultPanelColor = Color.Black;
        
        public WeightTestUC()
        {
            InitializeComponent();
            defaultPanelColor = this.BackColor;
            SwitchLabels();

            RegisterClickEvent(this);
            foreach (var c in this.Controls.OfType<Control>())
            {
                RegisterClickEvent(c);
            }
            GlobalEventManager.instance.WeightUnitsSwitched += OnWeightUnitsSwitched;
        }

        protected override void OnUpdateControls(DeviceState state)
        {
            var arrow = Spinetester.instance.CurrentArrow;
            bool grams = Settings.WeightGrams;

            switch (state)
            {
                case DeviceState.Reset:
                    this.BackColor = defaultPanelColor;
                    SetText(labelMainValue,
                        arrow.Weight.Total > 0 ? arrow.Weight.GetString(grams) : Common.NoData);
                    SetText(labelSecondaryValue,
                        arrow.Weight.Total > 0 ? arrow.Weight.GetString(!grams) : Common.NoData);
                    break;
                case DeviceState.WeightTest:
                    this.BackColor = defaultPanelColor;
                    SetText(labelMainValue, arrow.GetTestedWeightString(grams));
                    SetText(labelSecondaryValue, arrow.GetTestedWeightString(!grams));
                    break;
                case DeviceState.WeightTestDone:
                    this.BackColor = Color.DarkSeaGreen;
                    SetText(labelMainValue, arrow.Weight.GetString(grams));
                    SetText(labelSecondaryValue, arrow.Weight.GetString(!grams));
                    break;
                default:
                    break;
            }
        }

        private void SwitchLabels()
        {
            bool grams = Settings.WeightGrams;
            SetText(labelMain,
                grams ? GlobalStrings.GramsLowcase : GlobalStrings.GrainsLowcase);
            SetText(labelSecondary,
                (!grams ? GlobalStrings.GramsLowcase : GlobalStrings.GrainsLowcase) + Common.Colon);
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
            GlobalEventManager.instance.OnWeightUnitsSwitched();
        }

        private void OnWeightUnitsSwitched()
        {
            SwitchLabels();
            SwitchLabelValues();
        }
    }
}
