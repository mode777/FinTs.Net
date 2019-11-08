﻿using System;
using Xunit;

namespace FinTsNet.Tests
{

    public class SignatureHeaderTests
    {

        [Fact]
        public void Test1()
        {
            var header = new SignatureHeader(2, "1234", "0", DateTime.Now, 76550000, "760794644");
            var ser = header.Serialize();

            var header2 = FinTsParser.Parse<SignatureHeader>(ser);

            Assert.Equal(ser, header2.Serialize());
        }
    }
}
