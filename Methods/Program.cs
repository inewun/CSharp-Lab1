using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Методы");

            Method method = new Method();

            do
            {
                Console.WriteLine("\nОтбрасывает дробную часть числа.");
                double value1 = InputDataWithCheck.InputDoubleWithValidation($"Введите вещественное число (от 1 до {double.MaxValue}) через запятую: ", 1.0, double.MaxValue);
                Console.WriteLine($"Дробная часть числа {value1}: {method.fraction(value1)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 1? (y/n): "));

            do
            {
                Console.WriteLine("\nПреобразовывает символ в соответствующее число.");
                char value3 = InputDataWithCheck.InputCharWithValidation("Введите символ (от 0 до 9): ", new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                Console.WriteLine($"Cимвол '{value3}' в число: {method.charToNums(value3)} {{{method.charToNums(value3).GetType().Name}}} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 3? (y/n): "));

            do
            {
                Console.WriteLine("Возвращает true, если число двузначное.");
                int value5 = InputDataWithCheck.InputIntegerWithValidation($"Введите натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                Console.WriteLine($"Число двузначное: {method.is2Digits(value5)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 5? (y/n): "));

            do
            {
                Console.WriteLine("Возвращает true, если число входит в заданный диапазон.");
                int lowerRange = InputDataWithCheck.InputIntegerWithValidation($"Введите нижнюю границу, натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                int upperRange = InputDataWithCheck.InputIntegerWithValidation($"Введите верхнюю границу, натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                int value7 = InputDataWithCheck.InputIntegerWithValidation($"Введите x, натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                Console.WriteLine($"Входит ли число в диапазон: {method.isInRange(lowerRange, upperRange, value7)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 7? (y/n): "));


            do
            {
                Console.WriteLine("Возвращает true, если все три числа равны.");
                int x = InputDataWithCheck.InputIntegerWithValidation($"Введите первое натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                int y = InputDataWithCheck.InputIntegerWithValidation($"Введите второе натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                int z = InputDataWithCheck.InputIntegerWithValidation($"Введите третье, натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                Console.WriteLine($"Три числа равны: {method.isEqual(x, y, z)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 9? (y/n): "));

            Console.WriteLine("\nПрограмма завершена.");
        }
    }
}
