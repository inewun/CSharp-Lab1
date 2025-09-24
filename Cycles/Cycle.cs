using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class Cycle
    {
        // Задание 1. Числа подряд
        public string listNums(int x)
        {
            string result = "";
            for (int i = 0; i <= x; i++)
            {
                result += i;
                if (i != x) result += " ";
            }
            return result;
        }

        // Задание 3. Четные числа
        public string chet(int x)
        {
            string result = "";
            for (int i = 0; i <= x; i += 2)
            {
                result += i;
                if (i + 2 <= x) result += " ";
            }
            return result;
        }


        // Задание 5. Длина числа
        public int numLen(long x)
        {
            int length = 0;
            long num = x < 0 ? -x : x;
            do
            {
                num /= 10;
                length++;
            } while (num > 0);
            return length;
        }

        // Задание 7. Квадрат
        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Задание 9. Правый треугольник
        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < x - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
