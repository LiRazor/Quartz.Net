using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Class
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = "1";
            string b = "2";
            string c = "2";
            Assert.AreEqual(c, b);
        }

        [TestMethod]
        public void Test2()
        {
            string a = "1";
            string b = "2";
            string c = "2";
            Assert.AreEqual(b, b);
        }
    }
}
