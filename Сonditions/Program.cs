using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2. Условия");

            Condition function = new Condition();

            do
            {
                Console.WriteLine("\nВозвращает модуль числа");
                int value1 = InputDataWithCheck.InputIntegerWithValidation("Введите целое число: ", int.MinValue, int.MaxValue);
                Console.WriteLine($"Модуль числа {value1}: {function.abs(value1)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 1? (y/n): "));

            do
            {
                Console.WriteLine("\nВозращает делимость на 3 ИЛИ на 5.");
                int value3 = InputDataWithCheck.InputIntegerWithValidation("Введите целое число: ", int.MinValue, int.MaxValue);
                Console.WriteLine($"Число {value3} делится на 3 или 5 (но не на оба): {function.is35(value3)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 3? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает максимум из трёх чисел.");
                int x = InputDataWithCheck.InputIntegerWithValidation("Введите целое число x: ", int.MinValue, int.MaxValue);
                int y = InputDataWithCheck.InputIntegerWithValidation("Введите целое число y: ", int.MinValue, int.MaxValue);
                int z = InputDataWithCheck.InputIntegerWithValidation("Введите целое число z: ", int.MinValue, int.MaxValue);
                Console.WriteLine($"Максимум из {x}, {y} и {z}: {function.max3(x, y, z)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 5? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает сумму чисел, но в диапазоне от 10 до 19, возвращает 20");
                int value7x = InputDataWithCheck.InputIntegerWithValidation("Введите целое число x: ", int.MinValue, int.MaxValue);
                int value7y = InputDataWithCheck.InputIntegerWithValidation("Введите целое число y: ", int.MinValue, int.MaxValue);
                Console.WriteLine($"Результат sum2({value7x}, {value7y}): {function.Sum2(value7x, value7y)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 7? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает день недели по числу.");
                int value9 = InputDataWithCheck.InputIntegerWithValidation("Введите целое число от 1 до 7: ", 1, 7);
                Console.WriteLine($"День недели для числа {value9}: {function.day(value9)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 9? (y/n): "));

            Console.WriteLine("\nПрограмма завершена.");
        }
    }
}
