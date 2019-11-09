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
            var header1 = new Hnhbk(1, 0);
            var serialized1 = header1.Serialize();

            var header2 = FinTsParser.Parse<Hnhbk>(serialized1);
            var serialized2 = header2.Serialize();

            Assert.Equal(serialized1, serialized2);
        }
    }
}
