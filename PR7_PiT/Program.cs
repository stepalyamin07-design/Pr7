using System;


namespace PR7_PiT
{
    internal class Program
    {
        /// <summary>
        /// Точка входа в приложение. Запрашивает у пользователя число и выводит соответствующее число Фибоначчи.
        /// </summary>
        /// <param name="args">Аргументы командной строки (не используются).</param>
        static void Main(string[] args)
        {
            int result = Fibonacci(5);
            Console.WriteLine(result);
        }
        /// <summary>
        /// Вычисляет n-е число Фибоначчи.
        /// </summary>
        /// <param name="n">Порядковый номер (начиная с 0).</param>
        /// <returns>Число Фибоначчи.</returns>
        static int Fibonacci(int n)
        {
            Console.WriteLine("The output is: ");
            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i < n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return n == 0 ? n1 : n2;
        }
    }
        }

