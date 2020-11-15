using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittestproject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int one = 1;
            int two = 2;
            Assert.IsTrue(one + two == 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int one = 1;
            int two = 2;
            Assert.IsTrue(one + two == 4);
        }
    }
}
