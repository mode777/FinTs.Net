using Xunit;

namespace FinTsNet.Tests
{
    public static class TestHelpers
    {
        public static void TestSerialization<T>(T element)
            where T : IFinTsElement, new()
        {
            var ser = element.Serialize();

            var element2 = FinTsParser.Parse<T>(ser);
            var ser2 = element2.Serialize();
            Assert.Equal(ser, ser2);
        }
    }
}
