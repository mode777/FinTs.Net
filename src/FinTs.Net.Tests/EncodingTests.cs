using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FinTsNet.Tests
{
    public class EncodingTests
    {
        [Fact]
        public void ShouldParse()
        {
            var input = "?+?:?'???@";
            var prepare = FinTsParser.UnescapeInput(input);

            var el = FinTsParser.Parse<AlphanumericElement>(prepare);

            Assert.Equal("+:'?@", el.Value);            
        }

        [Fact]
        public void ShouldEscape()
        {
            var el = new AlphanumericElement("+:'?@");

            var ser = el.Serialize();

            Assert.Equal("?+?:?'???@", ser);
        }
    }
}
