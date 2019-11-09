using Xunit;

namespace FinTsNet.Tests
{

    public class HksynTests
    {
        [Fact]
        public void Test1()
        {
            var id = new Hksyn(0, Hksyn.Query.SystemId);
            TestHelpers.TestSerialization(id);
        }
    }
}
