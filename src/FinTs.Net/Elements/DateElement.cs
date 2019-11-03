using System;
using System.Globalization;

namespace FinTsNet
{
    public class DateElement : IDataElement<DateTime>, IFinTsElement
    {
        public DateElement()
        {

        }

        public DateElement(DateTime time)
        {
            Value = time;
        }

        public DateTime Value { get; set; }

        public void Parse(string str)
        {
            Value = DateTime.ParseExact(str, "yyyyMMdd", CultureInfo.InvariantCulture);
        }

        public string Serialize()
        {
            return Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
        }
    }
}
