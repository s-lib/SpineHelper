using System;

namespace SpineHelper
{
    public class UnitsConverter
    {
        public static double GrainsToGrams(double grains)
        {
            return grains * 0.06479891;
        }

        public static int ToGrains(double grains)
        {
            return Convert.ToInt32(grains);
        }

        public static int GramsToGrains(double grams)
        {
            return Convert.ToInt32(grams * 15.4323584);
        }

        /*float convertAMOtoASTM(float amo)
        {
            return ((26.0 / amo) / SPINE_ASTM_TO_AMO_MODIFIER) * 1000.0;
        }

        float convertASTMtoAMO(float astm)
        {
            // FORMULA  = (26.0 / (ASTM * SPINE_ASTM_TO_AMO_MODIFIER)) * 1000.0; //for ASTM spine 300-2000
            return (26.0 / (astm * SPINE_ASTM_TO_AMO_MODIFIER)) * 1000.0;
        }*/


        public static int ToAMO(double spine)
        {
            return spine <= 0 ? 0 : Convert.ToInt32(spine); //TODO: check rounding
        }

        public static int ToASTM(double spine)
        {
            // spine == AMO as float float
            return spine <= 0 ? 0 : Convert.ToInt32(((26f / spine) / 0.825419) * 1000.0);
        }

        public static int GetFOC(double front, double back)
        {
            return Convert.ToInt32((front - ((front + back) / 2.0)) / (front + back) * 100.0);
        }


        public static double ConvertASTMtoAMO(double astm)
        {
            return (26.0 / (astm * 0.825419)) * 1000.0;
        }
    }
}
