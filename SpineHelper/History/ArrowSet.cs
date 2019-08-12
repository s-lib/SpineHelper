using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpineHelper.History
{
    [Serializable]
    public class ArrowSet
    {
        public int Index { get; private set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public ArrowData[] Arrows { get { return arrowList.ToArray(); } }


        public double ShaftLength { get; set; } //TODO: to implement with arrow sets
        //public double AccesoriesWeight { get; set; }

        public int ArrowCount { get { return arrowList.Count; } }

        private List<ArrowData> arrowList = new List<ArrowData>();


        public ArrowSet()
        {
        }

        public void Clear()
        {
            arrowList.Clear();
            Index = 0;
        }

        public bool Contains(ArrowData arrow)
        {
            return arrowList.Contains(arrow);
        }

        public ArrowData GetArrow(int index)
        {
            if (arrowList.Count > index && index >= 0)
                return arrowList[index];
            else
                return null;
        }

        public void AddArrow(ArrowData arrow)
        {
            arrow.Index = ++Index;
            arrowList.Add(arrow);
        }

        public int RemoveLast()
        {
            if (Index > 0 && arrowList.Count > 0)
            {
                Index -= 1;
                int id = arrowList[arrowList.Count - 1].Index;
                arrowList.RemoveAt(arrowList.Count - 1);
                return id;
            }
            else return -1;
        }

        public void RemoveByID(int id)
        {
            for (int i = arrowList.Count - 1; i >= 0; i--)
            {
                if (arrowList[i].Index == id)
                {
                    arrowList.RemoveAt(i);
                    return;
                }
            }
        }

        //public void RemoveAt(int index)
        //{
        //    arrowList.RemoveAt(index);
        //}

        public double GetArrowGPI(int index)
        {
            if (arrowList.Count > index)
                return Math.Round(arrowList[index].Weight.Grains / ShaftLength, 2);
            else
                return 0;
        }


        public object GetSummary(string parameterName, bool secondRow = false)
        {
            switch (parameterName)
            {
                case "Grains": if (secondRow) return GetParamSummary(ArrowData.Param.Grains); else return GetAvgWeightGrains();
                case "Grams": if (secondRow) return GetParamSummary(ArrowData.Param.Grams); else return GetAvgWeightGrams();
                case "ASTM": if (secondRow) return GetParamSummary(ArrowData.Param.ASTM); else return GetAvgSpineASTM();
                case "AMO": if (secondRow) return GetParamSummary(ArrowData.Param.AMO); else return GetAvgSpineAMO();
                case "Straightness": return secondRow ? null : GetStraightnessClass();
                //case "ASTM1": return SpineASTM1;
                //case "ASTM2": return SpineASTM2;
                //case "AMO1": return SpineAMO1;
                // case "AMO2": return SpineAMO2;
                case "GPI": if (secondRow) return GetParamSummary(ArrowData.Param.GPI); else return GetAvgGPI();
                //case "Comment": return Comment;
                case "ID":
                default:
                    return secondRow ? null : string.Empty;
            }
        }

        public string GetParamSummary(ArrowData.Param param)
        {
            switch (param)
            {
                case ArrowData.Param.ASTM:
                    return "± " + (GetParamDiff(param) / GetAvgSpineASTM() * 100).ToString(GetStringFormatingForParam(param)) + "%";

                default:
                    return "± " + GetParamDiff(param).ToString(GetStringFormatingForParam(param));
            }
        }

        public double GetParamDiff(ArrowData.Param param)
        {
            double highest = 0;
            double lowest = 1000000.0;
            double mod = 1.0;
            foreach (var a in arrowList)
            {
                if (a.GetParam(param) > highest) highest = a.GetParam(param);
                if (a.GetParam(param) < lowest) lowest = a.GetParam(param);
            }

            if (param == ArrowData.Param.Grams) mod = 10.0;

            return Math.Ceiling((highest - lowest) / 2.0 * mod) / mod;
        }

        private string GetStringFormatingForParam(ArrowData.Param param)
        {
            switch (param)
            {
                case ArrowData.Param.Grams: return Weight.GramFormat;
                case ArrowData.Param.GPI: return "0.0";
                case ArrowData.Param.Straightness: return Straightness.Format;
                case ArrowData.Param.Grains:
                case ArrowData.Param.ASTM:
                case ArrowData.Param.AMO:
                default: return "0";
            }
        }


        public int GetAvgWeightGrains()
        {
            int summary = 0;
            foreach(var a in arrowList) summary += a.Weight.Grains;
            return summary / arrowList.Count;
        }

        public double GetAvgWeightGrams()
        {
            double summary = 0;
            foreach (var a in arrowList) summary += a.Weight.Grams;
            return Math.Round(summary / arrowList.Count, 1);
        }

        public double GetAvgSpineASTM()
        {
            int summary = 0;
            foreach (var a in arrowList) summary += a.Spine.ASTM;
            return summary / arrowList.Count;
        }

        public double GetAvgSpineAMO()
        {
            int summary = 0;
            foreach (var a in arrowList) summary += a.Spine.AMO;
            return summary / arrowList.Count;
        }

        public double GetAvgGPI()
        {
            double summary = 0;
            foreach (var a in arrowList) summary += a.GPI;
            return Math.Round(summary / arrowList.Count, 1);
        }

        public string GetStraightnessClass()
        {
            double summary = 0;
            foreach (var a in arrowList)
            {
                if (a.Straightness.Value > summary)
                    summary = a.Straightness.Value;
            }

            return Straightness.GetGradeString(summary);
        }

        //public object GetDataByName(string name) //TODO: export names to some file
        //{
        //    switch (name)
        //    {
        //        case "ID": return Index;
        //        case "Grains": return WeightGrains;
        //        case "Grams": return WeightGrams;
        //        case "ASTM": return SpineASTM;
        //        case "AMO": return SpineAMO;
        //        case "Straightness": return Straightness;
        //        case "ASTM1": return SpineASTM1;
        //        case "ASTM2": return SpineASTM2;
        //        case "AMO1": return SpineAMO1;
        //        case "AMO2": return SpineAMO2;
        //        case "Comment": return Comment;
        //        default:
        //            return string.Empty;
        //    }
        //}





        public void SortByDataGridViewColumns(DataGridView dgv)
        {

        }
    }
}
