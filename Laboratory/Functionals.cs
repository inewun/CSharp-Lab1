using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    internal class Functionals
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

        // 1. Модуль числа
        public int abs(int x)
        {
            return x >= 0 ? x : -x;
        }

        // 3. Тридцать пять
        public bool is35(int x)
        {
            bool divisibleBy3 = (x % 3 == 0);
            bool divisibleBy5 = (x % 5 == 0);
            return divisibleBy3 != divisibleBy5;

        }

        // 5. Тройной максимум
        public int max3(int x, int y, int z)
        {
            int max = x > y ? x : y;
            return max > z ? max : z;
        }

        // 7. Двойная сумма
        public int Sum2(int x, int y)
        {
            int sum = x + y;
            if (sum >= 10 && sum <= 19)
                return 20;
            return sum;
        }

        // 9. День недели
        public string day(int x)
        {
            switch (x)
            {
                case 1: return "понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пятница";
                case 6: return "суббота";
                case 7: return "воскресенье";
                default: return "это не день недели";
            }
        }

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

        // Задание 1: Поиск первого значения
        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;
        }

        // Задание 3: Поиск максимального
        public int maxAbs(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array is empty or null");

            int maxIndex = 0;
            int maxAbsValue = Math.Abs(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                int absVal = Math.Abs(arr[i]);
                if (absVal > maxAbsValue)
                {
                    maxAbsValue = absVal;
                    maxIndex = i;
                }
            }

            return arr[maxIndex];
        }

        // Задание 5: Добавление массива в массив
        public int[] add(int[] arr, int[] ins, int pos)
        {
            //if (arr == null) arr = new int[0];
            //if (ins == null) ins = new int[0];
            //if (pos < 0) pos = 0;
            //if (pos > arr.Length) pos = arr.Length;

            int[] result = new int[arr.Length + ins.Length];

            for (int i = 0; i < pos; i++)
                result[i] = arr[i];

            for (int i = 0; i < ins.Length; i++)
                result[pos + i] = ins[i];

            for (int i = pos; i < arr.Length; i++)
                result[ins.Length + i] = arr[i];

            return result;
        }

        // Задание 7: Возвратный реверс
        public int[] reverseBack(int[] arr)
        {
            //if (arr == null) return null;

            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - 1 - i];
            }

            return result;
        }

        // Задание 9: Все вхождения
        public int[] findAll(int[] arr, int x)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) count++;
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    result[index] = i;
                    index++;
                }
            }
            return result;
        }

    }
}
