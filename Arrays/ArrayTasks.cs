using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ArrayTasks
    {
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
