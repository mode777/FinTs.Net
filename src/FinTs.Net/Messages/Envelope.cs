using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FinTsNet.Messages
{
    public class Envelope<T> : Message
        where T : IFinTsElement, new()
    {
        public Envelope()
        {
        }

        [FinTsElement(0)]
        public MessageHeader Header { get; set; }
        [FinTsElement(1)]
        public EncryptionHeader EncryptionHeader { get; set; }
        [FinTsElement(2)]
        public MessageFooter Footer { get; set; }
        public T Data { get; set; }

        public override void Parse(string str)
        {
            var regex = new Regex(@"HNVSD:999:1\+@[0-9]+@(.+')'");
            var rest = regex.Match(str).Groups[1].Value;
            Data = FinTsParser.Parse<T>(rest);
            str = regex.Replace(str, "");

            base.Parse(str);
        }

        
    }
}
