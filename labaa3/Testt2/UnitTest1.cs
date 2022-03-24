using System;
using Xunit;
using static labaa3.DateService;

namespace Test3
{
    public class UnitTest3
    {
        [Fact]
        public void Test1()
        {
            int s = labaa3.DateService.GetDaysSpan(22, 03, 2022);
            Assert.Equal(2, s);
        }


        [Fact]
        public void Test2()
        {
            int s = labaa3.DateService.GetDaysSpan(23, 03, 2022);
            Assert.Equal(1, s);
        }

        [Fact]
        public void Test3()
        {
            int s = labaa3.DateService.GetDaysSpan(1, 1, 2000);
            Assert.Equal(8118, s);
        }

        [Fact]
        public void Test4()
        {
            int s = labaa3.DateService.GetDaysSpan(24, 03, 2022);
            Assert.Equal(0, s);
        }
    }
}