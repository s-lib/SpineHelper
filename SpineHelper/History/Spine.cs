using System;
using SpineHelper.Data;

namespace SpineHelper.History
{
    [Serializable]
    public class Spine
    {
        public double Value { get { return Value2 > 0 ? (Value1 + Value2) / 2.0 : Value1; } }
        public double Value1 { get; set; }
        public double Value2 { get; set; }

        public double Raw { get { return Raw2 > 0 ? (Raw1 + Raw2) / 2.0 : Raw1; } }
        public double Raw1 { get; set; }
        public double Raw2 { get; set; }

        public int AMO { get { return UnitsConverter.ToAMO(Value); } }
        public int AMO1 { get { return UnitsConverter.ToAMO(Value1); } }
        public int AMO2 { get { return UnitsConverter.ToAMO(Value2); } }

        public int ASTM { get { return UnitsConverter.ToASTM(Value); } }
        public int ASTM1 { get { return UnitsConverter.ToASTM(Value1); } }
        public int ASTM2 { get { return UnitsConverter.ToASTM(Value2); } }

        public Spine()
        {
        }

        public void Reset()
        {
            Value1 = 0;
            Value2 = 0;
        }

        public void Set(double[] values)
        {
            double spine = values.Length > 0 ? values[0] : 0;
            double raw = values.Length > 1 ? values[1] : 0;
            if (Value1 > 0)
            {
                Value2 = spine;
                Raw2 = raw;
            }
            else
            {
                Value1 = spine;
                Raw1 = raw;
            }
        }

        public int Get(bool amo, int test = 0)
        {
            if (amo)
            {
                switch (test)
                {
                    case 0: return AMO;
                    case 1: return AMO1;
                    case 2: return AMO2;
                }
            }
            else
            {
                switch (test)
                {
                    case 0: return ASTM;
                    case 1: return ASTM1;
                    case 2: return ASTM2;
                }
            }
            return 0;
        }

    }
}
