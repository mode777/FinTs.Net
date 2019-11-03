namespace FinTsNet
{
    public class NumericElement : IDataElement<int>
    {
        public NumericElement()
        {
        }

        public NumericElement(int val)
        {
            Value = val;
        }

        public int Value { get; set; }

        public void Parse(string str)
        {
            Value = int.Parse(str);
        }

        public string Serialize()
        {
            return Value.ToString();
        }
    }
}
