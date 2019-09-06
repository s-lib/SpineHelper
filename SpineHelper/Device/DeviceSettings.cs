using System;

namespace SpineHelper.Device
{
    public class DeviceSettings
    {
        public double ScaleLeft { get; set; } = 1;
        public double ScaleRight { get; set; } = 1;
        public double FixedDeflection { get; set; } = 1;

        // Since v1.1 Firmware
        public double SpineDifference { get; private set; } = 6.0;
        public int HX711Frequency { get; private set; } = 6;

        // Since v1.2 Firmware
        public int SpeakerVolume { get; private set; } = 0;
        public int Language { get; private set; } = 0;

        public DeviceSettings()
        {
        }


        public string GetScaleString(bool left)
        {
            if (left)
                return ScaleLeft != 0 ? ScaleLeft.ToString() : Common.NoData;
            else
                return ScaleRight != 0 ? ScaleRight.ToString() : Common.NoData;
        }

        public string GetDeflectionString()
        {
            return FixedDeflection != 0 ? FixedDeflection.ToString() : Common.NoData;
        }


        public void GetStandardData(double[] values, int index = 0)
        {
            if (values.Length > index) ScaleLeft = values[index++];
            if (values.Length > index) ScaleRight = values[index++];
            if (values.Length > index) FixedDeflection = values[index++];
        }

        // Since v1.1 Firmware
        public void GetAdditionalData(double[] values, int index)
        {
            if (values.Length > index)
            {
                SpineDifference = values[index];
            }
            if (values.Length > ++index)
            {
                HX711Frequency = Convert.ToInt32(values[index]);
            }

            // Since v1.2 Firmware
            if (values.Length > ++index)
            {
                SpeakerVolume = Convert.ToInt32(values[index]);
            }
            if (values.Length > ++index)
            {
                Language = Convert.ToInt32(values[index]);
            }
        }

        public static string GetLanguageName(int value)
        {
            if (value >= 0 && value < Enum.GetValues(typeof(DeviceLanguage)).Length)
            {
                return ((DeviceLanguage)value).ToString();
            }

            return GlobalStrings.LanguageUnknown + " (" + value + ")";
        }
    }
}
