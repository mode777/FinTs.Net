using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FinTsNet.Messages
{
    public class Envelope<T> : Message
        where T : Message, new()
    {
        public Envelope()
        {
        }

        public Envelope(T message, DateTime date, int blz, string userId, string systemId)
        {
        
            Header = new Hnhbk(1, 1);
            EncryptionHeader = new Hnvsk(date, blz, userId, systemId);
            Data = message;
            Footer = new Hnhbs(1, message.Count() + 2);
        }

        [FinTsElement(0)]
        public Hnhbk Header { get; set; }
        [FinTsElement(1)]
        public Hnvsk EncryptionHeader { get; set; }
        [FinTsElement(2)]
        public Hnhbs Footer { get; set; }
        public T Data { get; set; }

        public override void Parse(string str)
        {
            var regex = new Regex(@"HNVSD:999:1\+@[0-9]+@(.+')'");
            var rest = regex.Match(str).Groups[1].Value;
            Data = FinTsParser.Parse<T>(rest);
            str = regex.Replace(str, "");

            base.Parse(str);
        }

        public override string Serialize()
        {
            var encryption = EncryptionHeader.Serialize();
            var content = Data.Serialize();
            var hnvsd = $"HNVSD:999:1+@{content.Length}@{content}";
            var footer = Footer.Serialize();

            var list = new[] { Header.Serialize(), encryption, hnvsd, footer };

            var length = list.Select(x => x.Length+1).Sum();

            Header.Size.Value = length;
            list[0] = Header.Serialize();

            return string.Join("'", list) + "'";
        }

        public override int Count()
        {
            return 2 + Data.Count();
        }

    }
}
