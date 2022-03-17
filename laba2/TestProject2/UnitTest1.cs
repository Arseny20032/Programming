using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace task2_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0,Result.task(-15, -15));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(0, Result.task(0, -2));
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal(-1, Result.task(-10, -5));
        }
        [Fact]
        public void Test4()
        {
            Assert.Equal(0, Result.task(0, 0));
        }
        [Fact]
        public void Test5()
        {
            Assert.Equal(-1, Result.task(-10, -5));
        }

    }
}