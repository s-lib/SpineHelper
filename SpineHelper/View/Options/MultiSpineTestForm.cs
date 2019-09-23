using SpineHelper.Data;
using SpineHelper.Device;
using SpineHelper.History;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpineHelper.View.Options
{
    public partial class MultiSpineTestForm : Form
    {

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
            if (dataGridView1.InvokeRequired)
            {
                var d = new Action(Reset);
                Invoke(d);
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
        }

        private void OnSpineTestPassed(double rawSpine)
        {
            AddToView(new MultiSpineTest(rawSpine));
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
    }
}
