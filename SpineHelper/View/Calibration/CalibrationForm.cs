using SpineHelper.Device;
using System;
using System.Windows.Forms;

namespace SpineHelper.View.Calibration
{
    public partial class CalibrationForm : Form
    {
        public enum Type { None, Weight, Spine }

        private Type typeSet;
        private UserControl uc;

        public CalibrationForm()
        {
            InitializeComponent();
            this.FormClosing += OnFormClosing;
            StartPosition = FormStartPosition.CenterScreen;

            ConnectionManager.instance.DeviceStateChanged += OnDeviceStateChanged;
        }

        public void Init(Type type)
        {
            if (this.typeSet == type) return;

            this.typeSet = type;


            switch (type)
            {
                case Type.Weight:
                    ConnectionManager.instance.Send(DeviceCodes.DEVICE_CODE_CALIBRATE_WEIGHT);
                    InitializeUC<CalibrationWeightUC>();
                    this.Text = GlobalStrings.CalibrationSensors;
                    label1.Text = GlobalStrings.CalibrationInstructionsWeight;
                    break;
                case Type.Spine:
                    //
                    InitializeUC<CalibrationSpineUC>();
                    this.Text = GlobalStrings.CalibrationSpine;
                    label1.Text = GlobalStrings.CalibrationInstructionsSpine;
                    break;
                default:
                    break;
            }
        }

        private void InitializeUC<T>() where T : UserControl, new()
        {
            if (uc != null)
                panelUC.Controls.Remove(uc);

            uc = new T();
            uc.Dock = DockStyle.Fill;
            panelUC.Controls.Add(uc);
        }


        private void OnFormClosing(Object sender, FormClosingEventArgs e)
        {
            ConnectionManager.instance.Send(DeviceCodes.DEVICE_CODE_CALIBRATION_END);
        }

        private void OnDeviceStateChanged(DeviceState state)
        {
            if (state == DeviceState.NotConnected)
                this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
