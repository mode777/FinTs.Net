namespace FinTsNet
{
    public class AlphanumericElement : IDataElement<string>
    {
        public AlphanumericElement()
        {
        }

        public AlphanumericElement(string str)
        {
            Value = str;
        }

        public string Value { get; set; }

        public void Parse(string str)
        {
            Value = str.Replace("&plu;", "+")
                .Replace("&col;", ":")
                .Replace("&sq;", "'")
                .Replace("&at;", "@");
        }

        public string Serialize()
        {
            return Value
                .Replace("?","??")
                .Replace("+", "?+")
                .Replace(":", "?:")
                .Replace("'", "?'")
                .Replace("@", "?@");
        }
    }
}
