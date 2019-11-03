using Xunit;

namespace FinTsNet.Tests
{
    public class MessageFooterTests
    {
        [Fact]
        public void Test1()
        {
            var footer1 = new MessageFooter(1, 0);
            var serialized1 = footer1.Serialize();

            var footer2 = FinTsParser.Parse<MessageFooter>(serialized1);
            var serialized2 = footer2.Serialize();

            Assert.Equal(serialized1, serialized2);
        }
    }
}
