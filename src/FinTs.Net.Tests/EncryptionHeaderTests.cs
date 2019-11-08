using System;
using Xunit;

namespace FinTsNet.Tests
{
    public class EncryptionHeaderTests
    {

        [Fact]
        public void Test1()
        {
            var header = new EncryptionHeader(DateTime.Now, 76550000, "760794644", "0");
            var ser = header.Serialize();

            var header2 = FinTsParser.Parse<EncryptionHeader>(ser);

            Assert.Equal(ser, header2.Serialize());
        }
    }
}
