using Xunit;

namespace FinTsNet.Tests
{
    public class ProcessInitTests
    {
        [Fact]
        public void Test1()
        {
            var pi = new Hnvvb(1, "abc", "1.0");
            TestHelpers.TestSerialization(pi);
        }
    }
}
