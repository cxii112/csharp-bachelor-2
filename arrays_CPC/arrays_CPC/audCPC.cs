using System;
using System.Linq;

namespace arrays_CPC
{
    internal class audCPC
    {
        public static void Main(string[] args)
        {
            const int n = 10;
            int[] numbers = new int[n];
            InitWithRandom(ref numbers);
            Print(numbers, "Исходный массив");
            Array.Sort(numbers);
            Print(numbers, "Отсортированный массив");
            PrintAllEven(numbers);
            Console.WriteLine($"Сумма {Sum(numbers)}");
            Console.WriteLine($"Произведение {Product(numbers)}");
            Console.WriteLine($"Среднее арифметическое {Average(numbers)}");

            Console.WriteLine("Пример 1");
            Print(numbers, "Исходный массив  ");
            for (int i = numbers.Length - 2; i >= 4; i--)
            {
                numbers[i + 1] = numbers[i];
            }
            numbers[4] = 10;
            Print(numbers, "Измененный массив");

            Console.WriteLine("Пример 2");
            Print(numbers, "Исходный массив  ");
            for (int i = 2; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[n - 1] = 0;
            Print(numbers, "Измененный массив");
        }

        // Исходный массив [81, 84, 14, 32, 97, 88, 85, 83, 11, 34]
        // Отсортированный массив [11, 14, 32, 34, 81, 83, 84, 85, 88, 97]
        // Четные элементы [14, 32, 34, 84, 88]
        // Сумма 609
        // Произведение 68653920952995840
        // Среднее арифметическое 60,9


        // Исходный массив [20, 72, 2, 92, 25, 49, 20, 97, 45, 95]
        // Отсортированный массив [2, 20, 20, 25, 45, 49, 72, 92, 95, 97]
        // Четные элементы [2, 20, 20, 72, 92]
        // Сумма 517
        // Произведение 2691871056000000
        // Среднее арифметическое 51,7

        private static void InitWithRandom(ref int[] destination)
        {
            Random random = new Random();
            for (int i = 0; i < destination.Length; i++)
            {
                destination[i] = random.Next(0, 100);
                // destination[i] = 1;
            }
        }

        private static int Sum(int[] of)
        {
            int sum = 0;
            foreach (int number in of)
            {
                sum += number;
            }

            return sum;
        }

        // произведение растет быстро, поэтому с запасом будет long
        private static long Product(int[] of)
        {
            long product = 1;
            foreach (int number in of)
            {
                product *= number;
            }

            return product;
        }

        private static double Average(int[] of)
        {
            return Sum(of) / (double)of.Length;
        }

        private static void Print(int[] source, string message = "")
        {
            Console.WriteLine($"{message} [{String.Join(", ", source)}]");
        }

        private static void PrintAllEven(int[] source)
        {
            // int[] evens = Array.FindAll(source, number => number % 2 == 0);
            int[] evens = source.Where(number => number % 2 == 0).ToArray();
            Print(evens, "Четные элементы");
        }
    }
}