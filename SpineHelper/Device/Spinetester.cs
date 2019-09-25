using SpineHelper.Data;
using SpineHelper.History;
using System;
using System.Globalization;

namespace SpineHelper.Device
{
    public sealed class Spinetester
    {
        public static readonly Spinetester instance = new Spinetester();

        public event Action<DeviceState, double[]> DataRecieved;
        public event Action<ArrowData> ArrowTaken;

        public DeviceModel Model { get; private set; } = new DeviceModel();
        public DeviceSettings Settings { get; private set; } = new DeviceSettings();
        public DeviceSettings Factory { get; private set; } = new DeviceSettings();

        public DeviceTension Tension { get; private set; } = new DeviceTension();
        public DeviceTension TensionSaved { get; private set; } = new DeviceTension();
        public double SpineTension { get { return Tension.Total - CurrentArrow.Weight.Total; } }


        public ArrowData CurrentArrow { get; private set; } = new ArrowData();

        private DeviceState state = DeviceState.NotConnected;

        static Spinetester()
        {
        }

        private Spinetester()
        {
            ConnectionManager.instance.DataRecieved += OnDataRecieved;
            ConnectionManager.instance.DeviceStateChanged += OnConnectionStateChanged;
        }

        public void NewArrow()
        {
            CurrentArrow = new ArrowData();
        }


        private void OnConnectionStateChanged(DeviceState state)
        {
            this.state = state;
            DataRecieved?.Invoke(state, null);
        }

        private void OnDataRecieved(string data)
        {
            ParseDataString(data);
        }


        private void ParseDataString(string data)
        {
            if (string.IsNullOrEmpty(data)) return;

            string code = data.Substring(0, DeviceCodes.CODE_LENGTH);

            double[] values = GetValuesFromString(data.Substring(DeviceCodes.CODE_LENGTH)
                                                      .Split(DeviceCodes.CODE_SEPARATOR));


            #if DEBUG
            Console.WriteLine("Recieved string: " + data);
            #endif

            //DeviceState newState = this.state;
            bool validCode = true;

            switch (code)
            {
                case DeviceCodes.CODE_RESET:
                    this.state = DeviceState.Reset;
                    ArrowTaken?.Invoke(CurrentArrow);
                    NewArrow();
                    break;
                case DeviceCodes.CODE_CONNECTED:
                    ConnectionManager.instance.SetConnectionState(DeviceState.Connected);
                    break;
                case DeviceCodes.CODE_LOADED:
                    ConnectionManager.instance.SetConnectionState(DeviceState.Ready);
                    break;
                case DeviceCodes.CODE_FACTORY:
                    Factory.GetStandardData(values); //0-2
                    Model.GetStandardData(values); //3-4
                    Factory.GetAdditionalData(values, 5); //5-6
                    break;
                case DeviceCodes.CODE_SCALE: //TODO: scaled is override by connected code below. Change it?
                    this.state = DeviceState.Scaled;
                    Settings.GetStandardData(values); //0-2
                    Settings.GetAdditionalData(values, 3); //3-4
                    //ConnectionManager.instance.SetConnectionState(DeviceState.Connected);
                    break;
                case DeviceCodes.CODE_TENSION_UNITS:
                    this.state = DeviceState.Tension;
                    Tension.GetData(values);
                    break;
                case DeviceCodes.CODE_WEIGHT_TEST:
                    this.state = DeviceState.WeightTest;
                    TensionSaved.GetData(values);
                    CurrentArrow.Tension = TensionSaved.Total;
                    break;
                case DeviceCodes.CODE_WEIGHT:
                    this.state = DeviceState.WeightTestDone;
                    CurrentArrow.Weight.Set(values);
                    break;
                case DeviceCodes.CODE_WEIGHT_CALIBRATION:
                    this.state = DeviceState.WeightCalibration;
                    TensionSaved.GetData(values);
                    break;
                case DeviceCodes.CODE_SPINE_TEST:
                    this.state = DeviceState.SpineTest;
                    TensionSaved.GetData(values);
                    CurrentArrow.Tension = TensionSaved.Total;
                    break;
                case DeviceCodes.CODE_SPINE:
                    this.state = DeviceState.SpineTestDone;
                    CurrentArrow.Spine.Set(values);
                    break;
                case DeviceCodes.CODE_STRAIGHTNESS:
                    this.state = DeviceState.StraightnessTestDone;
                    CurrentArrow.Straightness.Set(values);
                    break;
                default:
                    validCode = false;
                    break;
            }

            if (validCode)
                DataRecieved?.Invoke(this.state, values);
        }

        private double[] GetValuesFromString(string[] data)
        {
            double[] values = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                double result = 0;
                double.TryParse(data[i], NumberStyles.Number, CultureInfo.InvariantCulture, out result);
                values[i] = result;
            }
            return values;
        }




        public double GetRawSpineFromTension(double spineTension)
        {
           return SpineCalculator.GetSpineAMO(spineTension, Settings.FixedDeflection);
        }

        public bool RawSpineDifferencePassed(double previousSpineTension)
        {
            return Math.Abs(SpineTension - previousSpineTension) < Factory.SpineDifference;
        }

    }
}
