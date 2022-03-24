using System;
using Xunit;
using static labaa3.Canculator;

namespace Test1
{
    public class UnitTest1
    {
        [Fact]
        public void Test11()
        {
            int s = labaa3.Canculator.Max(25, 40);
            Assert.Equal(40, s);
        }

        [Fact]
        public void Test22()
        {
            int s = labaa3.Canculator.Max(25, 12);
            Assert.Equal(25, s);
        }

        [Fact]
        public void Test33()
        {
            int s = labaa3.Canculator.Max(12, 12);
            Assert.Equal(12, s);
        }
    }
}