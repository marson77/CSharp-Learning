using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

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
        public void Cycle()
        {
            for (int i = 0; i < 10; i = i + 1)
            {
                System.Console.Out.Write(i + "\n"); // Выводим значение счётчика на консоль (n  - перевод строки)
            }
        }

        [TestMethod] // для старых языков С, С++
        public void Array()
        {
            //string s = "test";// обьявляется переменная представляющая собой 1 единственную строку
            string[] d = new string[] { "I", "want", "to", "sleep!" }; //Создали массив

            for (int i = 0; i < d.Length; i = i + 1) // цикл на повтороение столько раз, сколько элементов в массиве
            {
                System.Console.Out.Write(d[i] + "\n"); // Выводим значение счётчика на консоль (n  - перевод строки)
            }
        }

        [TestMethod] // для C#
        public void ArrayCSharp()
        {
            string[] d = new string[] { "I", "want", "to", "sleep!" }; //Создали массив для контейнеров

            foreach (string element in d) // цикл на повтороение столько раз, сколько элементов в массиве
            {
                System.Console.Out.Write(element + "\n"); // Выводим значение счётчика на консоль (n  - перевод строки)
            }
        }

        //[TestMethod] // для C# Ожидание появления какого то элемента на странице
        //public void While()
        //{
        //    IWebDriver driver = null; //для защиты от бесконечного цикла добавляем параметр количества попыток
        //    int attempt = 0; //количество попыток

        //    while (driver.FindElements(By.Id("test")).Count == 0 && attempt < 60) //поиск по идентификатору (счётчик Count - сколько элементов найдено)
        //    {
        //        System.Threading.Thread.Sleep(1000); //Подождать 1 секунду
        //        attempt = attempt + 1; //на каждой итерации увеличиваем количество попыток на 1
        //        //или attempt++;
        //    }

        //    // ... (если элемент не найден - ждём 1 секунду, то повторяет снова поиск до 60 попыток, как только элемент найден Count>0, цикл прекращается и код идет дальше )
        //}

        //[TestMethod] // для C# Ожидание появления какого то элемента на странице
        //public void While2()
        //{
        //    IWebDriver driver = null; //для защиты от бесконечного цикла добавляем параметр количества попыток
        //    int attempt = 0;

        //    do
        //    {
        //        System.Threading.Thread.Sleep(1000);
        //        attempt++;
        //    } while (driver.FindElements(By.Id("test")).Count == 0 && attempt < 60); //поиск по идентификатору (счётчик Count - сколько элементов найдено)
        //} // тут проверка производится после 1 п
    }
}
