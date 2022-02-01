using System;

namespace recursion
{
    internal class L0102_1
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите n ");
            int n = Convert.ToInt32(Console.ReadLine());
            long factorial_N = factorial(n);
            Console.WriteLine($"{n}! = {factorial_N}");
        }

        private static long factorial(int n)
        {
            Console.WriteLine($"Рекурсивный вызов для n = {n}");
            if (n == 1 || n == 0)
            {
                Console.WriteLine($"Вычисление {n}! = {1}");
                return 1;
            }
            long result = n * factorial(n - 1);
            Console.WriteLine($"Вычисление {n}! = {result}");
            return result;
        }
    }
}