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
        }



        public void Reset()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Update();
        }

        private void OnTestFinished(double rawSpine)
        {
            var spine = new MultiSpineTest(rawSpine);

            dataGridView1.Rows.Add(
                new object[] {
                    dataGridView1.Rows.Count + 1,
                    spine.AMO,
                    spine.ASTM
                    }
                );
            dataGridView1.Update();
        }





        private class MultiSpineTest
        {
            public double Value { get; private set; }
            public int AMO { get { return UnitsConverter.ToAMO(Value); } }
            public int ASTM { get { return UnitsConverter.ToASTM(Value); } }

            public MultiSpineTest(double rawSpine)
            {
                //Value = Spinetester.GetSpineFromTension(rawSpine)
                //TODO: calculate spine basing on spinetester data
                //
            }
        }
    }
}
