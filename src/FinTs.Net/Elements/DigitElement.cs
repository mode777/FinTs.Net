namespace FinTsNet
{
    public class DigitElement : IDataElement<int>
    {
        public DigitElement(int size)
        {
            Size = size;
        }

        public DigitElement(int size, int val)
            : this(size)
        {
            Value = val;
        }

        public int Size { get; }
        public int Value { get; set; }

        public void Parse(string str)
        {
            Value = int.Parse(str);
        }

        public string Serialize()
        {
            return Value.ToString("D" + Size);
        }
    }
}
