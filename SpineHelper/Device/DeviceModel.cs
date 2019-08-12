using System.Globalization;

namespace SpineHelper.Device
{
    public class DeviceModel
    {
        public double Serial { get; private set; }
        public double Firmware { get; private set; }
        public string Bluetooth { get; private set; } = Common.NoData;
        public string Version { get { return Firmware < 1.1 ? "I" : "II"; } }
        public string Amplifier { get { return Firmware < 1.1 ? "HX711" : "HX711 HQ"; } }

        public string SerialString { get { return Serial.ToString("0000"); } }
        public string FirmwareString
            { get { return "v" + Firmware.ToString("0.0", CultureInfo.InvariantCulture); } }


        public DeviceModel()
        {
        }

        public void GetStandardData(double[] values, int index = 3)
        {
            if (values.Length > index) Firmware = values[index++];
            if (values.Length > index) Serial = values[index++];
        }

    }
}
