using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonditions
{
    class Condition
    {
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


    }
}
