using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Functionals function = new Functionals();

            Console.WriteLine("Задание 1. Методы");

            do
            {
                Console.WriteLine("\nОтбрасывает дробную часть числа.");
                double value1 = InputDataWithCheck.InputDoubleWithValidation($"Введите вещественное число (от 1 до {double.MaxValue}) через запятую: ", 1.0, double.MaxValue);
                Console.WriteLine($"Дробная часть числа {value1}: {function.fraction(value1)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 1? (y/n): "));

            do
            {
                Console.WriteLine("\nПреобразует символ в соответствующее число.");
                char value3 = InputDataWithCheck.InputCharWithValidation("Введите символ (от 0 до 9): ", new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                Console.WriteLine($"Cимвол '{value3}' в число: {function.charToNums(value3)} {{{function.charToNums(value3).GetType().Name}}} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 3? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает true, если число двузначное.");
                int value5 = InputDataWithCheck.InputIntegerWithValidation($"Введите натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                Console.WriteLine($"Число двузначное: {function.is2Digits(value5)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 5? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает true, если число входит в заданный диапазон.");
                int lowerRange = InputDataWithCheck.InputIntegerWithValidation($"Введите нижнюю границу, натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                int upperRange = InputDataWithCheck.InputIntegerWithValidation($"Введите верхнюю границу, натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                int value7 = InputDataWithCheck.InputIntegerWithValidation($"Введите x, натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                Console.WriteLine($"Входит ли число в диапазон: {function.isInRange(lowerRange, upperRange, value7)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 7? (y/n): "));


            do
            {
                Console.WriteLine("\nВозвращает true, если все три числа равны.");
                int x = InputDataWithCheck.InputIntegerWithValidation($"Введите первое натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                int y = InputDataWithCheck.InputIntegerWithValidation($"Введите второе натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                int z = InputDataWithCheck.InputIntegerWithValidation($"Введите третье, натуральное число (от 1 до {int.MaxValue}): ", 1, int.MaxValue);
                Console.WriteLine($"Три числа равны: {function.isEqual(x, y, z)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 9? (y/n): "));



            Console.WriteLine("\n\nЗадание 2. Условия");

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



            Console.WriteLine("\n\nЗадание 3. Циклы");

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



            Console.WriteLine("\n\nЗадание 4. Массивы");

            do
            {
                Console.WriteLine("\nВозвращает индекс первого вхождения числа в массив.");
                int[] array1 = InputDataWithCheck.InputIntegerArrayWithValidation();
                int value1 = InputDataWithCheck.InputIntegerWithValidation($"Введите натуральное число для поиска первого вхождения: ", 1, int.MaxValue);

                int indexFirst = function.findFirst(array1, value1);
                Console.WriteLine(indexFirst >= 0 ? $"Индекс первого вхождения {value1} в массив: {indexFirst} \n" : $"Число {value1} не найдено в массиве. \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 1? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает индекс максимального по модулю числа в массиве.");
                int[] array2 = InputDataWithCheck.InputIntegerArrayWithValidation();
                Console.WriteLine($"Максимальное по модулю значение в массиве: {function.maxAbs(array2)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 3? (y/n): "));

            do
            {
                Console.WriteLine("\nДобавляет массив в массив в заданную позицию.");
                int[] array5 = InputDataWithCheck.InputIntegerArrayWithValidation();
                int[] insertArray5 = InputDataWithCheck.InputIntegerArrayWithValidation("Введите элементы массива, который будет вставляться, через пробел: ");
                int position5 = InputDataWithCheck.InputIntegerWithValidation($"Введите позицию для вставки (целое натуральное число от 0 до {array5.Length}): ", 0, array5.Length);
                int[] result5 = function.add(array5, insertArray5, position5);
                Console.WriteLine($"Результат: [{string.Join(", ", result5)}] \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 5? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает массив, в котором значения записаны задом наперёд.");
                int[] array7 = InputDataWithCheck.InputIntegerArrayWithValidation();
                int[] reversedArray7 = function.reverseBack(array7);
                Console.WriteLine($"Реверс массива: [{string.Join(", ", reversedArray7)}] \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 7? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает массив с индексами всех вхождений числа.");
                int[] array9 = InputDataWithCheck.InputIntegerArrayWithValidation();
                int value9 = InputDataWithCheck.InputIntegerWithValidation($"Введите натуральное число для поиска всех индексов вхождения: ", 1, int.MaxValue);
                int[] indices = function.findAll(array9, value9);
                Console.WriteLine(indices.Length == 0 ? $"Число {value9} не найдено в массиве." : $"Индексы всех вхождений: [{string.Join(", ", indices)}] \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 9? (y/n): "));

            Console.WriteLine("\nПрограмма завершена.");
        }
    }
}
