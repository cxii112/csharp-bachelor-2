using System;

namespace staticMethods
{
    /**
     * @author Дмитрий Ляховой ММТ-2-2021
     */
    internal class L1801
    {
        public static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write($"Числитель 1-й дроби ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Знаменатель 1-й дроби ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Числитель 2-й дроби ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Знаменатель 2-й дроби ");
            d = Convert.ToInt32(Console.ReadLine());
            Summ(a, b, c, d);
            Console.WriteLine($"{a}/{b} - {c}/{d} = {Subtract(a, b, c, d):N5}");

            double multiplication, fraction;
            MultiplyAndDivide(ref a, ref b, ref c, ref d,
                              out multiplication,
                              out fraction);
            Console.WriteLine($"{a}/{b} * {c}/{d} = {multiplication:N5}");
            Console.WriteLine($"{a}/{b} / {c}/{d} = {fraction:N5}");
        }

        private static void Summ(int a, int b,
                                 int c, int d)
        {
            double result = (a * d + b * c) / (double)(b * d);
            Console.WriteLine($"{a}/{b} + {c}/{d} = {result:N5}");
        }

        private static double Subtract(int a, int b,
                                       int c, int d)
        {
            return ((a * d) - (c * b)) / (double)(b * d);
        }

        private static void MultiplyAndDivide(ref int    a, ref int b,
                                              ref int    c, ref int d,
                                              out double multiplied,
                                              out double divided)
        {
            multiplied = (a * c) / (double)(b * d);
            divided = (a * d) / (double)(b * c);
        }
    }
    /* Тест 1
     * 1/2 + 1/4 = 0,75
     * 1/2 - 1/4 = 0,25
     */
    /* Тест 2
     * 1/2 + 2/3 = 1,16667
     * 1/2 - 2/3 = -0,16667
     */
    /*
     * Числитель 1-й дроби 3
     * Знаменатель 1-й дроби 5
     * Числитель 2-й дроби 2
     * Знаменатель 2-й дроби 7
     * 3/5 - 2/7 = 0,31429
     * 3/5 + 2/7 = 0,88571
     */
    /*
     * Числитель 1-й дроби 1
     * Знаменатель 1-й дроби 2
     * Числитель 2-й дроби 1
     * Знаменатель 2-й дроби 2
     * 1/2 + 1/2 = 1,00000
     * 1/2 - 1/2 = 0,00000
     * 1/2 * 1/2 = 0,25000
     * 1/2 / 1/2 = 1,00000
     */
    /*
     * Числитель 1-й дроби 1
     * Знаменатель 1-й дроби 7
     * Числитель 2-й дроби 2
     * Знаменатель 2-й дроби 3
     * 1/7 + 2/3 = 0,80952
     * 1/7 - 2/3 = -0,52381
     * 1/7 * 2/3 = 0,09524
     * 1/7 / 2/3 = 0,21429
     */
}