using System;
using System.Globalization;

namespace SpineHelper.Device
{
    public class DeviceModel
    {
        private const int VersionCodeIndex = 9;
        private enum Mark { O = 0, I = 1, II = 2, III = 3 }

        public double Serial { get; private set; }
        public double Firmware { get; private set; }
        public string Bluetooth { get; private set; } = Common.NoData;

        public int Version { get; private set; } = 1;
        public string VersionString { get { return ((Mark)Version).ToString(); } }

        public string Amplifier { get { return Version > 1 ? "HX711 HQ" : "HX711"; } }

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

            if (Firmware == 1.1) Version = 2;

            // Since v1.2 Firmware
            if (values.Length > VersionCodeIndex) Version = Convert.ToInt32(values[VersionCodeIndex]);
        }

    }
}
