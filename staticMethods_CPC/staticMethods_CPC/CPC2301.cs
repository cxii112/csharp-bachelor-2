using System;

namespace staticMethods_CPC
{
    /**
     * @author Дмитрий Ляховой ММТ-2-2021
     */
    internal class CPC2301
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите n ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"n! = {CountFactorial(n)}");
            Console.WriteLine($"1! + 2! + .. + n! = {CountSumFactorial(n)}");
        }

        private static int CountFactorial(int n)
        {
            int factorial = 1;
            for (int i = 2; i <= n && factorial * i > 0; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int CountSumFactorial(int n)
        {
            int factorial = 1;
            int sum = 0;
            for (int i = 2; i <= n && factorial <= int.MaxValue - sum; i++)
            {
                sum += factorial;
                factorial *= i;
            }

            return sum;
        }
    }
}