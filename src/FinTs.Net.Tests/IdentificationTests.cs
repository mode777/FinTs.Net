﻿using Xunit;

namespace FinTsNet.Tests
{

    public class IdentificationTests
    {
        [Fact]
        public void Test1()
        {
            var id = new Hkidn(3, 76550000, "760794644");
            TestHelpers.TestSerialization(id);
        }
    }
}
