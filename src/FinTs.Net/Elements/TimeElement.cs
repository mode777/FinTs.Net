using System;
using System.Globalization;

namespace FinTsNet
{
    public class TimeElement : IDataElement<TimeSpan>, IFinTsElement
    {
        public TimeElement()
        {
        }

        public TimeElement(TimeSpan value)
        {
            Value = value;
        }

        public TimeElement(DateTime date)
        {
            Value = date.TimeOfDay;
        }

        public TimeSpan Value { get; set; }

        public void Parse(string str)
        {
            Value = TimeSpan.ParseExact(str, "hhmmss", CultureInfo.InvariantCulture);
        }

        public string Serialize()
        {
            return Value.ToString("hhmmss", CultureInfo.InvariantCulture);
        }
    }
}
