using System.Text;

namespace FinTsNet
{
    public class BinaryElement : IDataElement<byte[]>, IFinTsElement
    {
        public byte[] Value { get; set; }

        public BinaryElement()
        {
        }

        public BinaryElement(byte[] bytes)
        {
            Value = bytes;
        }

        public BinaryElement(string data)
        {
            Value = Encoding.GetEncoding("ISO-8859-1").GetBytes(data);
        }

        public void Parse(string str)
        {
            var split = str.Split('@');
            Value = Encoding.GetEncoding("ISO-8859-1").GetBytes(split[2]);
        }

        public string Serialize()
        {
            return $"@{Value.Length}@{Encoding.GetEncoding("ISO-8859-1").GetString(Value)}";
        }
    }
}
