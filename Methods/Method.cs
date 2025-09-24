using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Method
    {
        public double fraction(double x)
        {
            return Math.Round(x % 1, 5);
        }

        public int charToNums(char x)
        {
            return Convert.ToInt32(x) - 48;
        }

        public bool is2Digits(int x)
        {
            return x / 100 == 0 && x / 10 > 0;
        }

        public bool isInRange(int a, int b, int num)
        {
            return Math.Min(a, b) < num && num < Math.Max(a, b);
        }

        public bool isEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }
    }
}
