using System;

namespace FinTsNet
{
    public class SecurityDateTime : ElementGroup
    {
        public SecurityDateTime()
        {
        }

        public SecurityDateTime(DateTime time)
        {
            Type = new AlphanumericElement("1");
            Date = new DateElement(time);
            Time = new TimeElement(time);
        }

        [FinTsElement(0)]
        public AlphanumericElement Type { get; set; }
        [FinTsElement(1)]
        public DateElement Date { get; set; }
        [FinTsElement(2)]
        public TimeElement Time { get; set; }
    }
}
