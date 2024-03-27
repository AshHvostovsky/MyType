using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyType.Tests
{
    [TestClass()]
    public class FractionTests
    {

        [TestMethod()]
        public void ToStringTest1() //Проверка на преобразования типа Дроби в строку 1/10
        {
            var fraction = new Fraction(1, 10);
            Assert.AreEqual("1/10", fraction.ToString());
        }
        [TestMethod()]
        public void ToStringTest2() //Проверка на преобразования типа Дроби в строку 0/0 -> 0
        {
            var fraction = new Fraction(0, 0);
            Assert.AreEqual("0", fraction.ToString());
        }
        [TestMethod()]
        public void ToStringTest3() //Проверка на преобразования типа Дроби в строку 8/1 -> 8
        {
            var fraction = new Fraction(8, 1);
            Assert.AreEqual("8", fraction.ToString());
        }
        [TestMethod()]
        public void normilizeTest1() //Проверка на сокращение дроби 5/10 -> 1/2
        {
            var fraction = new Fraction(5, 10);
            fraction.normilize();
            Assert.AreEqual("1/2", fraction.ToString());
        }
        [TestMethod()]
        public void normilizeTest2() //Проверка на нормализацию дроби 1/-10 - > -1/10
        {
            var fraction = new Fraction(1, -10);
            fraction.normilize();
            Assert.AreEqual("-1/10", fraction.ToString());
        }
        [TestMethod()]
        public void normilizeTest3() //Проверка на нормализацию дроби -1/-10 - > 1/10
        {
            var fraction = new Fraction(-1, -10);
            fraction.normilize();
            Assert.AreEqual("1/10", fraction.ToString());
        }
        [TestMethod()]
        public void findMaxTest1() //Проверка на поиск наибольшего общего делителя для двух чисел алгоритмом Евклида
        {
            var fraction = new Fraction(1, 10);
            Assert.AreEqual(10, fraction.findMax(10, 50)); //Общий делитель для 10 и 50 это 10
        }
        [TestMethod()]
        public void findMaxTest2() //Проверка на поиск наибольшего общего делителя для двух чисел алгоритмом Евклида
        {
            var fraction = new Fraction(1, 10);
            Assert.AreEqual(10, fraction.findMax(50, 10)); //Общий делитель для 50 и 10 это 10
        }

        [TestMethod()]
        public void sravnTest1() //Проверка на сравнение одной дроби + сокращение дроби. Одинаковые знаменатели
        {
            var fraction1 = new Fraction(1, 10);
            var fraction2 = new Fraction(2, 10);
            string res = fraction1 + fraction1.sravn(fraction2) + fraction2;
            Assert.AreEqual("1/10 < 1/5", res);
        }
        [TestMethod()]
        public void sravnTest2() //Проверка на сравнение одной дроби с другой. Одинаковые знаменатели
        {
            var fraction1 = new Fraction(1, 10);
            var fraction2 = new Fraction(-1, 10);
            string res = fraction1 + fraction1.sravn(fraction2) + fraction2;
            Assert.AreEqual("1/10 > -1/10", res);
        }
        [TestMethod()]
        public void sravnTest3() //Проверка на сравнение одной дроби с другой. Одинаковые знаменатели
        {
            var fraction1 = new Fraction(-1, 10);
            var fraction2 = new Fraction(-1, 10);
            string res = fraction1 + fraction1.sravn(fraction2) + fraction2;
            Assert.AreEqual("-1/10 = -1/10", res);
        }
        [TestMethod()]
        public void sravnTest4() //Проверка на сравнение одной дроби с другой  + сокращение дроби. Одинаковые знаменатели
        {
            var fraction1 = new Fraction(-1, 10);
            var fraction2 = new Fraction(-5, 10);
            string res = fraction1 + fraction1.sravn(fraction2) + fraction2;
            Assert.AreEqual("-1/10 > -1/2", res);
        }
        [TestMethod()]
        public void sravnTest5() //Проверка на сравнение одной дроби с другой. Разные знаменатели
        {
            var fraction1 = new Fraction(3, 22);
            var fraction2 = new Fraction(5, 64);
            string res = fraction1 + fraction1.sravn(fraction2) + fraction2;
            Assert.AreEqual("3/22 > 5/64", res);
        }

        /*Далее математические действия с дробями*/
        [TestMethod()]
        public void sumTest1() //Сложение одинаковых дробей
        {
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(1, 4);
            var res = fraction1 + fraction2;
            Assert.AreEqual("1/2", res.ToString());
        }
        [TestMethod()]
        public void sumTest2() //Сложение дробей с разными знаменателями
        {
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(1, 8);
            var res = fraction1 + fraction2;
            Assert.AreEqual("3/8", res.ToString()); //Результат 12/32, но сокращается до 3/8
        }
        [TestMethod()]
        public void sumTest3() //Сложение отрицательной дроби с положительной
        {
            var fraction1 = new Fraction(-1, 4);
            var fraction2 = new Fraction(1, 4);
            var res = fraction1 + fraction2;
            Assert.AreEqual("0", res.ToString());
        }
        [TestMethod()]
        public void sumTest4() //Сложение двух отрицательных дробей
        {
            var fraction1 = new Fraction(-1, 4);
            var fraction2 = new Fraction(-1, 4);
            var res = fraction1 + fraction2;
            Assert.AreEqual("-1/2", res.ToString()); //Результат -2/4, но сокращается до -1/2
        }
        [TestMethod()]
        public void vichitTest1() //Вычитание одинаковых дробей
        {
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(1, 4);
            var res = fraction1 - fraction2;
            Assert.AreEqual("0", res.ToString());
        }
        [TestMethod()]
        public void vichitTest2() //Вычитание дробей с разными знаменателями
        {
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(1, 8);
            var res = fraction1 - fraction2;
            Assert.AreEqual("1/8", res.ToString()); //Результат 4/32, но сокращается до 1/8
        }
        [TestMethod()]
        public void vichitTest3() //Вычитание от отрицательной дроби положительную
        {
            var fraction1 = new Fraction(-1, 4);
            var fraction2 = new Fraction(1, 4);
            var res = fraction1 - fraction2;
            Assert.AreEqual("-1/2", res.ToString()); //Результат -2/8, но сокращается до -1/2
        }
        [TestMethod()]
        public void vichitTest4() //Вычитание двух отрицательных дробей
        {
            var fraction1 = new Fraction(-1, 4);
            var fraction2 = new Fraction(-1, 4);
            var res = fraction1 - fraction2;
            Assert.AreEqual("0", res.ToString()); //Минус на минус плюс
        }
        [TestMethod()]
        public void vichitTest5() //Вычитание от положительной дроби отрицательной
        {
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(-1, 4);
            var res = fraction1 - fraction2;
            Assert.AreEqual("1/2", res.ToString()); //Минус на минус плюс, результат 2/4, но сокращается до 1/2
        }
        [TestMethod()]
        public void umnozTest1() //Умножение положительной дроби на отрицательную
        {
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(-1, 4);
            var res = fraction1 * fraction2;
            Assert.AreEqual("-1/16", res.ToString());
        }
        [TestMethod()]
        public void umnozTest2() //Умножение отрицательной дроби на отрицательную
        {
            var fraction1 = new Fraction(-1, 4);
            var fraction2 = new Fraction(-1, 4);
            var res = fraction1 * fraction2;
            Assert.AreEqual("1/16", res.ToString()); //минус на минус - плюс
        }
        [TestMethod()]
        public void delTest1() //Деление положительной дроби на отрицательную
        {
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(-1, 4);
            var res = fraction1 / fraction2;
            Assert.AreEqual("-1", res.ToString()); //сокращение дроби
        }
        [TestMethod()]
        public void delTest2() //Деление отрицательной дроби на отрицательную
        {
            var fraction1 = new Fraction(-1, 4);
            var fraction2 = new Fraction(-1, 4);
            var res = fraction1 / fraction2;
            Assert.AreEqual("1", res.ToString()); //минус на минус - плюс
        }
    }
}