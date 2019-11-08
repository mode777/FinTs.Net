using Xunit;

namespace FinTsNet.Tests
{
    public class IdentificationTests
    {

        [Fact]
        public void Test1()
        {
            var id = new Identification(3, 76550000, "760794644");
            var ser = id.Serialize();

            var id2 = FinTsParser.Parse<EncryptionHeader>(ser);
            var ser2 = id2.Serialize();
            Assert.Equal(ser, ser2);
        }
    }
}
