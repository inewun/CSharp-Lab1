using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сycles;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3. Циклы");

            Cycle function = new Cycle();

            do
            {
                Console.WriteLine("\nВозвращает строку с числами от 0 до x включительно:");
                int value1 = InputDataWithCheck.InputIntegerWithValidation("Введите целое число x: ", 0, int.MaxValue);
                Console.WriteLine($"Строка c числами от 0 до {value1}: {function.listNums(value1)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 1? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает строку с чётными числами от 0 до x включительно:");
                int value3 = InputDataWithCheck.InputIntegerWithValidation("Введите целое число x: ", 0, int.MaxValue);
                Console.WriteLine($"Строка с чётными числами от 0 до {value3}: {function.chet(value3)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 3? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает длину числа (количество цифр):");
                long value5 = InputDataWithCheck.InputLongWithValidation("Введите целое число x: ");
                Console.WriteLine($"Длина числа {value5}: {function.numLen(value5)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 5? (y/n): "));

            do
            {
                Console.WriteLine("\nВыводит квадрат из символов '*'.");
                int value7 = InputDataWithCheck.InputIntegerWithValidation("Введите размер стороны квадрата: ", 1, int.MaxValue);
                function.square(value7);
                Console.WriteLine();
            } while (InputDataWithCheck.AskRepeat("Повторить задание 7? (y/n): "));

            do
            {
                Console.WriteLine("\nВыводит правый треугольник из символов '*'.");
                int value9 = InputDataWithCheck.InputIntegerWithValidation("Введите высоту треугольника x: ", 1, int.MaxValue);
                function.rightTriangle(value9);
                Console.WriteLine();
            } while (InputDataWithCheck.AskRepeat("Повторить задание 9? (y/n): "));

            Console.WriteLine("\nПрограмма завершена.");
        }
    }
}
