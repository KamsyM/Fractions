using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fractions;

namespace Fractoin_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_1()
        {
            var a = new Fraction(2, 3); // 2/3
            var b = new Fraction(1, 4); // 1/4
            Assert.AreEqual("11/12", a.Plus(b).ToString());
        }

        [TestMethod]
        public void test_2()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(1, 4);
            Assert.AreEqual("5/12", a.Minus(b).ToString());
        }

        [TestMethod]
        public void test_3()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(1, 4);
            Assert.AreEqual("1/6", a.MultiplyBy(b).ToString());
        }

        [TestMethod]
        public void test_4()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(1, 4);
            Assert.AreEqual("2&2/3", a.DivideBy(b).ToString());
        }

    }
}
