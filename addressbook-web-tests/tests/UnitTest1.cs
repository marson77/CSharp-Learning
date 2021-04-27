using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace addressbook_web_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSquare()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            Assert.AreEqual(s1.Size, 5);
            Assert.AreEqual(s2.Size, 10);
            Assert.AreEqual(s3.Size, 5);

            s3.Size = 15;

            Assert.AreEqual(s1.Size, 15);

            s2.Colored = true;
        }

        // или можно так
        //Assert.AreEqual(s1.getSize(), 5);
        //Assert.AreEqual(s2.getSize(), 10);
        //Assert.AreEqual(s3.getSize(), 5);
        //
        //s3.setSize(15);
        //
        //Assert.AreEqual(s1.getSize(), 15);
        //}

        [TestMethod]
        public void TestMethodCircle()
        {
            Circle s1 = new Circle(5);
            Circle s2 = new Circle(10);
            Circle s3 = s1;

            Assert.AreEqual(s1.Radius, 5);
            Assert.AreEqual(s2.Radius, 10);
            Assert.AreEqual(s3.Radius, 5);

            s3.Radius = 15;

            Assert.AreEqual(s1.Radius, 15);

            s2.Colored = true;

            //Assert.AreEqual(s2.Colored, 0000x1);
         }

        //Лекция 3

        [TestMethod]
        public void If_then_else()
        {
            double total = 999;
            //double total = 1500;
            //bool vipClient = false;
            bool vipClient = true;

            //if (total > 1000 && vipClient) // должно выполниться 2 условия (&&) - и
            if (total > 1000 || vipClient) // (||) - или
            {
                total = total * 0.9;
                System.Console.Out.Write("Скидка 10%, общая сумма " + total);
            }
            else // при вышеописанном условии можно убрать блок else
            {
               System.Console.Out.Write("Скидки нет, общая сумма " + total);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            for (int i = 0; i < 10; i = i + 1)
            {
                System.Console.Out.Write(i + "\n"); // Выводим значение счётчика на консоль (n  - перевод строки)
            }
        }

    }
}
