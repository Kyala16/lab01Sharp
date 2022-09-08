using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace lab01Lib.Tests
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void AreaCulc_10and10_100returned()
        {
            double side1 = 10;
            double side2 = 10;
            double result = 100;

            Rectangle recTest = new Rectangle(side1, side2);

            Assert.AreEqual(result, recTest.Area);
            Assert.AreEqual(result, recTest.AreaCalculator());
        }

        [TestMethod]
        public void AreaCulc_doubleAndDouble_Double()
        {
            double side1 = 3.14;
            double side2 = 5.26;
            double result = 16.5164;

            Rectangle recTest = new Rectangle(side1, side2);

            Assert.AreEqual(result, recTest.Area);
            Assert.AreEqual(result, recTest.AreaCalculator());
        }

        [TestMethod]
        public void Perimeter_5and16_42returned()
        {
            double side1 = 5;
            double side2 = 16;
            double result = 42;

            Rectangle recTest = new Rectangle(side1, side2);

            Assert.AreEqual(result, recTest.Perimeter);
            Assert.AreEqual(result, recTest.PerimeterCalculator());
        }

        [TestMethod]
        public void Perimeter_doubleAndDouble_Double()
        {
            double side1 = 3.22;
            double side2 = 4.44;
            double result = 15.32;

            Rectangle recTest = new Rectangle(side1, side2);

            Assert.AreEqual(result, recTest.Perimeter);
            Assert.AreEqual(result, recTest.PerimeterCalculator());
        }
    }
}
