using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01Lib
{
    public class Point
    {
        private int X;
        private int Y;

        public Point(int x, int y) => (X, Y) = (x, y);

        public int GetX
        {
            get
            {
                return X;
            }
        }
        public int GetY
        {
            get
            {
                return Y;
            }
        }
    }
}
