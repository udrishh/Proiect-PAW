
namespace CustomChartLibrary
{
    public class ChartValue
    {
        #region Atribute
        public string Label { set; get; }
        public int Value { set; get; }
        #endregion

        #region Constructori
        public ChartValue(string label, int value)
        {
            Label = label;
            Value = value;
        }
        #endregion
    }
}
