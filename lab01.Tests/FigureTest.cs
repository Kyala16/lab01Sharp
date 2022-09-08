using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab01Lib.Tests
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void Name_getTrueName()
        {
            Point p1 = new(0, 1);
            Point p2 = new(1, 1);
            Point p3 = new(2, 1);
            Point p4 = new(2, 2);
            Point p5 = new(1, 0);

            Figure fig1 = new(p1, p2, p3);
            Figure fig2 = new(p1, p2, p3, p4);
            Figure fig3 = new(p1, p2, p3, p4, p5);

            Assert.AreEqual(fig1.GetName, "Triangle");
            Assert.AreEqual(fig2.GetName, "Rectangle");
            Assert.AreEqual(fig3.GetName, "Pentagon");
        }

        [TestMethod]
        public void Length_getTwoPoint_ReturnLength()
        {
            Point p1 = new(4, 0);
            Point p2 = new(0, 3);
            Point p3 = new(0, 0);
            Figure fig = new(p1, p2, p3);

            double answer1 = 5;
            double answer2 = 4;
            double answer3 = 3;

            Assert.AreEqual(answer1, fig.LengthSide(p1, p2));
            Assert.AreEqual(answer2, fig.LengthSide(p1, p3));
            Assert.AreEqual(answer3, fig.LengthSide(p3, p2));
        }

        [TestMethod]
        public void Perimeter_getFourPoint_ReturnPerimeter()
        {
            Point p1 = new(0, 0);
            Point p2 = new(0, 4);
            Point p3 = new(4, 4);
            Point p4 = new(4, 0);

            Figure Square = new(p1, p2, p3, p4);

            double answer = 16;

            Assert.AreEqual(answer, Square.GetPerimeter);
        }
    }
}
