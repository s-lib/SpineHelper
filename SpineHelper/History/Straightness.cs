using System;

namespace SpineHelper.History
{
    [Serializable]
    public class Straightness
    {
        public const string Format = "0.000";

        public double Value { get; private set; }
        public double Grade { get { return GetGrade(Value); } }

        public string String { get { return Value.ToString(Format); } }
        public string GradeString { get { return GetGradeString(Value); } }

        public Straightness()
        {
        }

        public void Reset()
        {
            Value = 0;
        }

        public void Set(double[] values)
        {
            Value = values.Length > 0 ? values[0] : 0;
        }

        public static double GetGrade(double spine)
        {
            return Math.Ceiling(spine * 1000.0 / 2.0) / 1000.0;
        }

        public static string GetGradeString(double spine)
        {
            return "±" + GetGrade(spine).ToString(Format);
        }
    }
}
