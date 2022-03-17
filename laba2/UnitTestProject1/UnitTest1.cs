using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task2.Program
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Result.task(-15, -15), 0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Result.task(0, 0), 0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(Result.task(68, -15), 1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(Result.task(-10, -5), -1);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(Result.task(0, -2), 0);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(Result.task(56, 22), 1);
        }
    }
}