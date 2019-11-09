using Xunit;

namespace FinTsNet.Tests
{
    public class CancellationResponseTests
    {
        [Fact]
        public void Test1()
        {
            var response1 = new CancellationResponse
            {
                Header = new Hnhbk(1, 0),
                Feedback = ResponseFeedbackTests.CreateExample(),
                Footer = new Hnhbs(1, 0)
            };
            var serialized1 = response1.Serialize();

            var response2 = FinTsParser.Parse<CancellationResponse>(serialized1);
            var serialized2 = response2.Serialize();

            Assert.Equal(serialized1, serialized2);
        }
    }
}
