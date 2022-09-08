using System;

namespace lab01Lib
{
    
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
}
