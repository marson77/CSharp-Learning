using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace addressbook_web_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            Assert.AreEqual(s1.Size, 5);
            Assert.AreEqual(s2.Size, 10);
            Assert.AreEqual(s3.Size, 5);

            s3.Size = 15;

            Assert.AreEqual(s1.Size, 15);
        }

        // или можно так
            //Assert.AreEqual(s1.getSize(), 5);
            //Assert.AreEqual(s2.getSize(), 10);
            //Assert.AreEqual(s3.getSize(), 5);
            //
            //s3.setSize(15);
            //
            //Assert.AreEqual(s1.getSize(), 15);
        }
}
}
