using SpineHelper.Data;
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

            spineTestUC1.SpineTestPassed += OnSpineTestPassed;
            
            Reset();
        }



        public void Reset()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
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
                //Value = Spinetester.GetSpineFromTension(rawSpine)
                //TODO: calculate spine basing on spinetester data
                //
            }
        }
    }
}
