using FinTsNet.Messages;
using System;
using Xunit;

namespace FinTsNet.Tests
{
    public class EnvelopeTests
    {
        //[Fact]
        //public void Parse()
        //{
        //    var envelope = new Envelope<ResponseFeedback>();
        //    envelope.Parse("HNHBK:1:3+000000000402+300+0+1'HNVSK:998:3+PIN:1+998+1+1::0+1:20191103:145131+2:2:13:@8@00000000:5:1+280:76550000:760794644:V:0:0+0'HNVSD:999:1+@240@HNSHK:2:4+PIN:1+999+1013023275975712+1+1+1::0+1+1:20191103:145131+1:999:1+6:10:16+280:76550000:760794644:S:0:0'HKIDN:3:2+280:76550000+760794644+0+1'HKVVB:4:3+0+0+0+9FA6681DEC0CF3046BFC2F8A6+0.1'HKSYN:5:3+0'HNSHA:6:2+1013023275975712++bl4d4''HNHBS:7:1+1'");
        //}

        [Fact]
        public void Serialize_ShouldCalculateCorrectLength()
        {
            var date = DateTime.Now;
            var msg = new SynchronizationMessage("0", date, 76550000, "760794644", "abc", "0.1", Hksyn.Query.SystemId, "1234");
            var env = new Envelope<SynchronizationMessage>(msg, date, 76550000, "760794644", "0");

            var ser = env.Serialize();

            //env = FinTsParser.Parse<Envelope<SynchronizationMessage>>(ser);

            Assert.Equal(ser.Length, env.Header.Size.Value);
        }
    }
}
