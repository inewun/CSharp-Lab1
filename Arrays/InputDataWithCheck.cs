using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class InputDataWithCheck
    {
        // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.  
        static public int InputIntegerWithValidation(string message, int left, int right)
        {
            bool ok;
            int value;
            do
            {
                Console.Write(message);
                ok = int.TryParse(Console.ReadLine(), out value);
                if (ok && (value < left || value > right))
                {
                    ok = false;
                }

                if (!ok)
                {
                    ConsoleColor tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                    Console.WriteLine("Повторите ввод\n");
                    Console.ForegroundColor = tmp;
                }
            } while (!ok);

            return value;
        }

        // Ввод вещественного числа с проверкой правильности ввода и принадлежности диапазону
        static public double InputDoubleWithValidation(string message, double left, double right)
        {
            bool ok;
            double value;
            do
            {
                Console.Write(message);
                ok = double.TryParse(Console.ReadLine(), out value);
                if (ok && (value < left || value > right))
                {
                    ok = false;
                }

                if (!ok)
                {
                    var tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(
                        $"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                    Console.WriteLine("Повторите ввод\n");
                    Console.ForegroundColor = tmp;
                }
            } while (!ok);

            return value;
        }

        static public int[] InputIntegerArrayWithValidation(string message = "Введите элементы массива через пробел: ")
        {
            int[] result = null;
            bool ok = false;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    string[] parts = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    result = new int[parts.Length];
                    ok = true;
                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (!int.TryParse(parts[i], out result[i]))
                        {
                            ok = false;
                            break;
                        }
                    }
                }

                if (!ok)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введены некорректные данные. Пожалуйста, введите список целых чисел, разделённые пробелом.\n");
                    Console.ResetColor();
                }
            } while (!ok);

            return result;
        }


        // Ввод символа с проверкой правильности ввода и принадлежности к разрешённым символам
        static public char InputCharWithValidation(string message, char[] allowedChars)
        {
            bool ok;
            char value;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();

                ok = !string.IsNullOrEmpty(input) && input.Length == 1 && Array.Exists(allowedChars, c => c == input[0]);

                if (ok)
                    value = input[0];
                else
                    value = default;

                if (!ok)
                {
                    var tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nВведенный символ недопустим. Разрешены: {string.Join(", ", allowedChars)}");
                    Console.WriteLine("Повторите ввод\n");
                    Console.ForegroundColor = tmp;
                }
            }
            while (!ok);

            return value;
        }

        // Вопрос к пользователю о продолжении с проверкой ввода
        static public bool AskRepeat(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "y")
                    return true;
                if (input == "n")
                    return false;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Пожалуйста, введите 'y' для да или 'n' для нет.\n");
                Console.ResetColor();
            }
        }
    }
}
