using System;
using static System.Console;
namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            WriteLine("Простой калькулятор");
            int x, y;
            Write("Введите число ");
            x = Convert.ToInt32(ReadLine());
            Write("Введите число ");
            y = Convert.ToInt32(ReadLine());
            WriteLine("Вот ответ + - * /");
            WriteLine($"{x} + {y} = {x + y}");
            WriteLine($"{x} - {y} = {x - y}");
            WriteLine($"{x} * {y} = {x * y}");
            WriteLine($"{x} / {y} = {x / y}");
            WriteLine();
            int max = 0;
            if (x > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }
            WriteLine("Максимальное число " + max);
            int min = 0;
            if (x < y)
            {
                min = x;
            }
            else
            {
                min = y;
            }
            WriteLine("Минимальное число " + min);

        }
    }
}
