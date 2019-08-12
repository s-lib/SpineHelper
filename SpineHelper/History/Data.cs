using System;
namespace SpineHelper.History
{
    public class Data
    {
        [Flags]
        public enum Column : uint
        {
            None = 0,
            ID = 1,
            Grains = 2,
            Grams = 4,
            ASTM = 8,
            AMO = 16,
            Straightness = 32,
            ASTM1 = 64,
            AMO1 = 128,
            ASTM2 = 256,
            AMO2 = 512,
            Comment = 1024,
            GPI = 2048
        }
    }
}
