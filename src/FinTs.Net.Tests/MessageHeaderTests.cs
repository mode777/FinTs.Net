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
            var header1 = new MessageHeader(1);
            var serialized1 = header1.Serialize();

            var header2 = FinTsParser.Parse<MessageHeader>(serialized1);
            var serialized2 = header2.Serialize();

            Assert.Equal(serialized1, serialized2);
        }
    }

    public class CancellationResponseTests
    {
        [Fact]
        public void Test1()
        {
            var response1 = new CancellationResponse
            {
                Header = new MessageHeader(1),
                Feedback = ResponseFeedbackTests.CreateExample(),
                Footer = new MessageFooter(1)
            };
            var serialized1 = response1.Serialize();

            var response2 = FinTsParser.Parse<CancellationResponse>(serialized1);
            var serialized2 = response2.Serialize();

            Assert.Equal(serialized1, serialized2);
        }
    }
}
