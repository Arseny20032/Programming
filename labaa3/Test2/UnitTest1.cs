using System;
using Xunit;
using static labaa3.Services.Task2;

namespace Test2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double s = labaa3.Services.Task2.Funtion(78);
            Assert.Equal(-1.6320886767332554, s);
        }
    }
}