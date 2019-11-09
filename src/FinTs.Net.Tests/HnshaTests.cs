using Xunit;

namespace FinTsNet.Tests
{
    public class HnshaTests
    {
        [Fact]
        public void Test1()
        {
            var id = new Hnsha(0, "abc", "def");
            TestHelpers.TestSerialization(id);
        }
    }
}
