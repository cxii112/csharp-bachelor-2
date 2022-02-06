using System;

namespace recursion_CPC
{
    /**
     * Вариант №4
     * @author Дмитрий Ляховой ММТ-2-2021
     */
    internal sealed class CPC0102
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Вариант 4");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Функция Аккермана A({n},{m}) = {AckermannFunction(n,m)}");
            
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x}^{p} = {Pow(x, p)}");
            
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма цифр числа {k} = {NumbersSum(k)}");
        }

        private static int AckermannFunction(int n, int m)
        {
            if (n == 0) return m + 1;
            if (m == 0) return AckermannFunction(n - 1, 1);
            if (m > 0 && n > 0)
                return AckermannFunction(n - 1,
                                         AckermannFunction(n, m - 1));
            return 0;
        }

        private static double Pow(double x, int n)
        {
            if (n < 0) return 1 / Pow(x, -n);
            if (n > 0) return x * Pow(x, n - 1);
            return 1;
        }

        private static int NumbersSum(int k)
        {
            int lastNumber = k % 10;
            return lastNumber + NumbersSum(k / 10);
        }
    }
}