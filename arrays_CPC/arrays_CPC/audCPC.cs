using System;

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
            Console.Write("Четный массив [");
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] % 2 != 0) continue;
                Console.Write($"{source[i]} ");
            }
            Console.WriteLine("]");
        }
    }
}