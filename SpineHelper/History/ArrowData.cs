using System;
using System.Globalization;
using SpineHelper.Data;

namespace SpineHelper.History
{
    [Serializable]
    public class ArrowData
    {
        public enum Param { Grains, Grams, ASTM, AMO, Straightness, GPI }

        public int Index { get; set; }

        // Temp value when testing shaft
        public double Tension { get; set; }

        public Weight Weight { get; private set; } = new Weight();
        public Spine Spine { get; private set; } = new Spine();
        public Straightness Straightness { get; private set; } = new Straightness();

        public bool BasicTestDone { get { return Spine.Value1 > 0; } }
        public bool AllTestsDone { get { return Spine.Value2 > 0; } }


        public double Length { get; set; } = 28;
        public double GPI { get { return Math.Ceiling(Weight.Grains * 10.0 / Length) / 10.0; } }

        public string Comment { get; set; }
        public int Hash { get; private set; }

        public ArrowData()
        {
            Hash = new Random().Next(1,99) * 1000000;
        }

        public void Reset()
        {
            Weight.Reset();
            Spine.Reset();
            Straightness.Reset();
            Comment = string.Empty;
        }

        public void ChangeIndex(int index)
        {
            if (index > 0)
                Index = index;
        }

        public override bool Equals(object obj)
        {
            var item = obj as ArrowData;

            if (item == null) return false;

            return (this.Hash == item.Hash) &&
                (this.Spine.Value == item.Spine.Value) && (this.Weight == item.Weight);
        }

        public override int GetHashCode()
        {
            return (this.Hash + this.Spine.ASTM * 1000 + this.Weight.Total).GetHashCode();
        }

        public string GetTestedWeightString(bool grams)
        {
            return grams ? UnitsConverter.GrainsToGrams(Tension).ToString(Weight.GramFormat)
                         : UnitsConverter.ToGrains(Tension).ToString(Weight.GrainFormat);
        }

        public int GetTestedSpine(bool amo)
        {
            return amo ? UnitsConverter.ToAMO(Tension) : UnitsConverter.ToASTM(Tension);
        }

        public double GetParam(Param type)
        {
            switch (type)
            {
                case Param.Grains: return Weight.Grains;
                case Param.Grams: return Weight.Grams;
                case Param.ASTM: return Spine.ASTM;
                case Param.AMO: return Spine.AMO;
                case Param.Straightness: return Straightness.Value;
                case Param.GPI: return GPI;
                default:
                    return 0;
            }
        }

        
        public object GetDataByIndex(int index)
        {
            switch (index)
            {
                case 0: return Index;
                case 1: return Weight.Grains;
                case 2: return Weight.Grams;
                default: return 0;
            }
        }

        public object GetDataByName(string name)
        {
            switch (name)
            {
                case "ID": return Index;
                case "Grains": return Weight.Grains;
                case "Grams": return Weight.Grams;
                case "ASTM": return Spine.ASTM;
                case "AMO": return Spine.AMO;
                case "Straightness": return Straightness.Value;
                case "ASTM1": return Spine.ASTM1;
                case "ASTM2": return Spine.ASTM2;
                case "AMO1": return Spine.AMO1;
                case "AMO2": return Spine.AMO2;
                case "GPI": return GPI;
                case "Comment": return Comment;
                default:
                    return string.Empty;
            }
        }
        public void SetDataByName(string name, string value) //TODO: export names to some file
        {
            switch (name)
            {
                case "Length": SetLength(value); break;
                case "Comment": Comment = value; break;
                default:
                    break;
            }
        }

        public object[] ToArray()
        {
            return new object[]
            {
                this.Index,
                this.Weight.Grains,
                this.Weight.Grams,
                this.Spine.ASTM,
                this.Spine.AMO,
                this.Straightness.Value,
                this.Spine.ASTM1,
                this.Spine.AMO1,
                this.Spine.ASTM2,
                this.Spine.AMO2,
                //this.GPI,
                this.Comment
            };
        }


        private void SetLength(string value)
        {
            double length = 0;
            double.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out length);
            if (length > 0)
                Length = length;
        }



    }
}
