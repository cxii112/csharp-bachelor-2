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
            // Task1();
            Task2();
        }

        private static void Task1()
        {
            Console.Write("Введите n ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"n! = {CountFactorial(n)}");
            Console.WriteLine($"1! + 2! + .. + n! = {CountSumFactorial(n)}");
        }

        private static void Task2()
        {
            Console.WriteLine("Вариант №4");
            Console.Write("Введите a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"X = {CountX(a, b, c)}");
        }

        private static int CountFactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                // если число будет слишком большим, то оно станет отрицательным
                // чтобы этого избежать проверим что следующий множитель стал не положительным
                // если да, то выйдем из цмкла
                if  (factorial * i <= 0) break;
                factorial *= i;
            }

            return factorial;
        }

        private static int CountSumFactorial(int n)
        {
            // int factorial = 1;
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                // factorial *= i;
                // int factorial = CountFactorial(i);
                // если текущее слагаемое больше, чем может поместить тип int
                // то выходим из цикла 
                if (sum > int.MaxValue - CountFactorial(i)) break;
                sum += CountFactorial(i);
            }

            return sum;
        }

        private static double CountX(int a, int b, int c)
        {
            return CountFraction(a) +
                   CountFraction(b) +
                   CountFraction(c);
        }

        private static double CountFraction(int a)
        {
            return ((Math.Sqrt(2 * a) - a) / (Math.Sqrt(a) + 2 * a));
        }
    }
    /*
     * Введите n 0
     * n! = 1
     * 1! + 2! + .. + n! = 1
     */
    
    /*
     * Введите n 5
     * n! = 120
     * 1! + 2! + .. + n! = 154
     */
    
    /*
     * Введите n 13
     * n! = 1932053504
     * 1! + 2! + .. + n! = 522956314
     */
    
    /*
     * Введите n 26
     * n! = 2004189184
     * 1! + 2! + .. + n! = 522956314
     */
    
    /*
     * Введите n 99
     * n! = 2004189184
     * 1! + 2! + .. + n! = 522956314
     */
}