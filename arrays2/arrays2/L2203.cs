using System;
using System.Runtime.InteropServices;
using System.Text;

namespace arrays2
{
    /**
     * @author Дмитрий Ляховой ММТ-2-2021
     * Вариант 4
     */
    internal class L2203
    {
        private static int N4;

        public static void Main(string[] args)
        {
            Console.WriteLine("Вариант 4");
            Console.Write("Введите количество элементов ");
            N4 = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[N4 + 5];

            InitWithRandom(ref numbers);
            Print(numbers, 5, message:"Исходный массив");
            Console.WriteLine($"Сумма элементов = {Sum(numbers)}");
            FillUsingCondition(ref numbers);
            Print(numbers, message:"Заполненный массив");
        }

        private static void InitWithRandom(ref double[] destination)
        {
            Random random = new Random();
            for (int i = 5; i < destination.Length; i++)
            {
                destination[i] = random.NextDouble() * 42 - 14;
            }
        }

        private static double Sum(double[] of)
        {
            double sum = 0;
            foreach (double number in of)
            {
                sum += number;
            }

            return sum;
        }

        private static void FillUsingCondition(ref double[] destination)
        {
            double sum = Sum(destination);
            for (int i = 0; i < 5; i++)
            {
                destination[i] = sum;
            }
        }

        private static void Print(double[] source, 
                                  int      from    = 0,
                                  string   message = "")
        {
            Console.Write($"{message} [");
            for (int i = from; i < source.Length; i++)
            {
                Console.Write($"{source[i]:N3}; ");
            }
            Console.WriteLine($"]");
        }
    }
}
