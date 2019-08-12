using System;
using SpineHelper.Data;

namespace SpineHelper.History
{
    [Serializable]
    public class Weight
    {
        public enum Unit { Grains, Grams }
        public const string GrainFormat = "0";
        public const string GramFormat = "0.0";

        public double Left { get; set; }
        public double Right { get; set; }
        public double Total { get { return Left + Right; } }

        public int Grains { get { return UnitsConverter.ToGrains(Total); } }
        public double Grams { get { return Math.Round(UnitsConverter.GrainsToGrams(Total), 1); } }



        public Weight()
        {
        }

        public void Reset()
        {
            Left = 0;
            Right = 0;
        }

        public void Set(double[] values)
        {
            Left = values.Length > 0 ? values[0] : 0;
            Right = values.Length > 1 ? values[1] : 0;
        }

        public double Get(Unit type)
        {
            switch (type)
            {
                case Unit.Grains: return Grains;
                case Unit.Grams: return Grams;
                default:
                    return Grains;
            }
        }

        public string GetString(bool grams)
        {
            return grams ? Grams.ToString(GramFormat) : Grains.ToString(GrainFormat);
        }

    }
}
