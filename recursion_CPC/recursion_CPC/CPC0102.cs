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
            Task1();
            Task2();
            TaskAdvanced();
        }

        private static void Task1()
        {
            Console.WriteLine("Задание 1. Функция Аккермана");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            // Не рекурентный вызов Ackermann
            Console.WriteLine($"Функция Аккермана A({n},{m}) = {AckermannFunction(n, m)}");
        }

        private static void Task2()
        {
            Console.WriteLine("Задание 2. Функция степени");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            int p = Convert.ToInt32(Console.ReadLine());
            // Не рекурентный вызов Pow
            Console.WriteLine($"{x}^{p} = {Pow(x, p)}");
        }

        private static void TaskAdvanced()
        {
            Console.WriteLine("Задание дополнительное. Сумма цифр числа");
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            // Не рекурентный вызов NumbersSum
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
            // Ветвь для отрицательного показателя степени
            if (n < 0) return 1 / Pow(x, -n);
            // Ветвь для положительного показателя степени
            if (n > 0)
            {
                double result = x * Pow(x, n - 1);
                return result;
            }
            // Не рекурентная ветвь
            return 1;
        }

        private static int NumbersSum(int k)
        {
            int absK = Math.Abs(k);
            // Не рекурентная ветвь
            if (absK < 10) return absK;
            int lastDigit = absK % 10;
            return lastDigit + NumbersSum(absK / 10);
        }
    }
}