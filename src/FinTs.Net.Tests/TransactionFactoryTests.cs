using FinTsNet.Messages;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FinTsNet.Tests
{
    public class TransactionFactoryTests
    {
        [Fact]
        public async  Task TestSync() 
        {
            var fac = GetFactory();

            var msg = fac.Sync(Hksyn.Query.SystemId);

            var ser = msg.Serialize();
            
            var client = new HttpClient();

            var encoding = Encoding.GetEncoding("ISO-8859-1");

            byte[] toEncodeAsBytes = encoding.GetBytes(ser);
            var b64 = Encoding.ASCII.GetBytes(Convert.ToBase64String(toEncodeAsBytes));

            var req = await client.PostAsync("https://banking-by1.s-fints-pt-by.de/fints30", new ByteArrayContent(b64));
            var res = await req.Content.ReadAsStringAsync();
            var resMsg = encoding.GetString(Convert.FromBase64String(res));
        }

        private TransactionFactory GetFactory()
        {
            var connData = new ConnectionData
            {
                ProductId = "9FA6681DEC0CF3046BFC2F8A6",
                ProductVersion = "0.1",
                Url = "https://banking-by1.s-fints-pt-by.de/fints30"
            };

            var sessionData = new SessionData
            {
                SystemId = "0"
            };

            var userData = new UserData
            {
                Blz = 76550000,
                UserId = "760794644",
                Pin = "XXXX"
            };

            return new TransactionFactory(connData, sessionData, userData);
        }

    }
}
