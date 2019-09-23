using SpineHelper.Data;
using SpineHelper.Device;
using SpineHelper.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpineHelper.View.Options
{
    public partial class MultiSpineTestForm : Form
    {
        private List<MultiSpineTest> resultsList = new List<MultiSpineTest>();


        public MultiSpineTestForm()
        {
            InitializeComponent();

            spineTestUC1.MultiSpineAllowed = true;

            // Register events
            spineTestUC1.SpineTestPassed += OnSpineTestPassed;
            Spinetester.instance.DataRecieved += OnDeviceDataRecieved;

            Reset();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Unregister events
            spineTestUC1.SpineTestPassed -= OnSpineTestPassed;
            Spinetester.instance.DataRecieved -= OnDeviceDataRecieved;
        }


        private void OnDeviceDataRecieved(DeviceState state, double[] values)
        {
            switch (state)
            {
                case DeviceState.Reset: Reset(); break;
                default: break;
            }
        }

        public void Reset()
        {
            resultsList.Clear();
            SetLabelText(labelHighID, Common.NoData);
            SetLabelText(labelHighAMO, Common.NoData);
            SetLabelText(labelHighASTM, Common.NoData);
            SetLabelText(labelLowID, Common.NoData);
            SetLabelText(labelLowAMO, Common.NoData);
            SetLabelText(labelLowASTM, Common.NoData);
            ResetDataGrid();
        }

        private void OnSpineTestPassed(double rawSpine)
        {
            var spine = new MultiSpineTest(rawSpine);
            resultsList.Add(spine);
            AddToView(spine);

            // Update min-max values
            var stiffest = resultsList.OrderByDescending(r => r.Value).First();
            var weakest = resultsList.OrderByDescending(r => r.Value).Last();

            SetLabelText(labelHighID, (resultsList.IndexOf(stiffest) + 1).ToString());
            SetLabelText(labelHighAMO, stiffest.AMO.ToString());
            SetLabelText(labelHighASTM, stiffest.ASTM.ToString());
            SetLabelText(labelLowID, (resultsList.IndexOf(weakest) + 1).ToString());
            SetLabelText(labelLowAMO, weakest.AMO.ToString());
            SetLabelText(labelLowASTM, weakest.ASTM.ToString());
        }

        private void AddToView(MultiSpineTest spine)
        {
            if (dataGridView1.InvokeRequired)
            {
                var d = new Action<MultiSpineTest>(AddToView);
                Invoke(d, new object[] { spine });
            }
            else
            {
                dataGridView1.Rows.Add(new object[] {
                    dataGridView1.Rows.Count + 1,
                    spine.AMO,
                    spine.ASTM }
                    );
                dataGridView1.Refresh();
            }
        }


        private class MultiSpineTest
        {
            public double Value { get; private set; }
            public int AMO { get { return UnitsConverter.ToAMO(Value); } }
            public int ASTM { get { return UnitsConverter.ToASTM(Value); } }

            public MultiSpineTest(double rawSpine)
            {
                Value = rawSpine;
            }
        }

        private void ResetDataGrid()
        {
            if (dataGridView1.InvokeRequired)
            {
                var d = new Action(ResetDataGrid);
                Invoke(d);
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
        }

        protected void SetLabelText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                var d = new Action<Label, string>(SetLabelText);
                Invoke(d, new object[] { label, text });
            }
            else
            {
                label.Text = text;
            }
        }
    }
}
