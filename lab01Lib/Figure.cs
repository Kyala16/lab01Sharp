using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01Lib
{
    public class Figure
    {
        private double Perimeter = 0;
        private Point[] Points;
        private string Name;

        public Figure(Point point1, Point point2, Point point3)
        {
            Points = new Point[3] { point1, point2, point3 };
            Name = "Triangle";
            PerimeterCalcullator();
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            Points = new Point[4] { point1, point2, point3, point4 };
            Name = "Rectangle";
            PerimeterCalcullator();
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            Points = new Point[5] { point1, point2, point3, point4, point5 };
            Name = "Pentagon";
            PerimeterCalcullator();
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.GetX-B.GetX), 2) + Math.Pow((A.GetY - B.GetY), 2));
        }

        public void PerimeterCalcullator()
        {
            for (int i = 0; i < Points.Length-1; ++i)
            {
                Perimeter += LengthSide(Points[i], Points[i + 1]);
            }
            Perimeter += LengthSide(Points[Points.Length - 1], Points[0]);
        }

        public string GetName
        {
            get
            {
                return Name;
            }
        }

        public double GetPerimeter
        {
            get
            {
                return Perimeter;
            }
        }
    }
}
