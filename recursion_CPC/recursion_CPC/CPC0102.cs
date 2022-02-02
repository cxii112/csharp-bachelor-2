using System;

namespace recursion_CPC
{
    /**
     * Вариант №4
     * @author Дмитрий Ляховой ММТ-2-2021
     */
    internal class CPC0102
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Вариант 4");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Функция Акермана A({n},{m}) = {AckermannFunction(n,m)}");
        }

        private static double AckermannFunction(double n, double m)
        {
            if (n == 0) return m + 1;
            if (m == 0) return AckermannFunction(n - 1, 1);
            if (m > 0 && n > 0)
                return AckermannFunction(n - 1,
                                         AckermannFunction(n, m - 1));
            return 0;
        }
    }
}