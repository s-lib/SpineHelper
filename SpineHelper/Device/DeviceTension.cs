
namespace SpineHelper.Device
{
    public class DeviceTension
    {
        public double Left { get; set; }
        public double Right { get; set; }
        public double Total { get { return Left + Right; } }
        public double Average { get { return Total / 2; } }

        public DeviceTension()
        {
        }

        public void GetData(double[] values, int index = 0)
        {
            Left = values.Length > index ? values[index] : 0;
            index++;
            Right = values.Length > index ? values[index] : 0;
        }
    }
}
