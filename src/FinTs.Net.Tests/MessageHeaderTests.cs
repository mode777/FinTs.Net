using FinTsNet;
using System;
using System.Reflection;
using Xunit;

namespace FinTsNet.Tests
{
    public class MessageHeaderTests
    {
        [Fact]
        public void Test1()
        {
            var header1 = new MessageHeader(1, 0);
            var serialized1 = header1.Serialize();

            var header2 = FinTsParser.Parse<MessageHeader>(serialized1);
            var serialized2 = header2.Serialize();

            Assert.Equal(serialized1, serialized2);
        }
    }

    public class SignatureHeaderTests
    {
        [Fact]
        public void Test1()
        {
            var header = new SignatureHead(2, "1234", "0", DateTime.Now, 76550000, "760794644");
            var ser = header.Serialize();

            var header2 = FinTsParser.Parse<SignatureHead>(ser);

            Assert.Equal(ser, header2.Serialize());
        }
    }
}
