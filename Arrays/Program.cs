using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayTasks arrayTasks = new ArrayTasks();

            Console.WriteLine("Задание 4. Массивы");

            do
            {
                Console.WriteLine("\nВозвращает индекс первого вхождения числа в массив.");
                int[] array1 = InputDataWithCheck.InputIntegerArrayWithValidation();
                int value1 = InputDataWithCheck.InputIntegerWithValidation($"Введите натуральное число для поиска первого вхождения: ", 1, int.MaxValue);

                int indexFirst = arrayTasks.findFirst(array1, value1);
                Console.WriteLine(indexFirst >= 0 ? $"Индекс первого вхождения {value1} в массив: {indexFirst} \n" : $"Число {value1} не найдено в массиве. \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 1? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает индекс максимального по модулю числа в массив.");
                int[] array2 = InputDataWithCheck.InputIntegerArrayWithValidation();
                Console.WriteLine($"Максимальное по модулю значение в массиве: {arrayTasks.maxAbs(array2)} \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 3? (y/n): "));

            do
            {
                Console.WriteLine("\nДобавляет массив в массив в заданную позицию.");
                int[] array5 = InputDataWithCheck.InputIntegerArrayWithValidation();
                int[] insertArray5 = InputDataWithCheck.InputIntegerArrayWithValidation("Введите элементы массива, который будет вставляться, через пробел: ");
                int position5 = InputDataWithCheck.InputIntegerWithValidation($"Введите позицию для вставки (целое натуральное число от 0 до {array5.Length}): ", 0, array5.Length);
                int[] result5 = arrayTasks.add(array5, insertArray5, position5);
                Console.WriteLine($"Результат: [{string.Join(", ", result5)}] \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 5? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает массив, в котором значения записаны задом наперёд.");
                int[] array7 = InputDataWithCheck.InputIntegerArrayWithValidation();
                int[] reversedArray7 = arrayTasks.reverseBack(array7);
                Console.WriteLine($"Реверс массива: [{string.Join(", ", reversedArray7)}] \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 7? (y/n): "));

            do
            {
                Console.WriteLine("\nВозвращает массив с индексами всех вхождений числа.");
                int[] array9 = InputDataWithCheck.InputIntegerArrayWithValidation();
                int value9 = InputDataWithCheck.InputIntegerWithValidation($"Введите натуральное число для поиска всех индексов вхождения: ", 1, int.MaxValue);
                int[] indices = arrayTasks.findAll(array9, value9);
                Console.WriteLine(indices.Length == 0 ? $"Число {value9} не найдено в массиве.": $"Индексы всех вхождений: [{string.Join(", ", indices)}] \n");
            } while (InputDataWithCheck.AskRepeat("Повторить задание 9? (y/n): "));

            Console.WriteLine("\nПрограмма завершена.");
        }
    }
}
