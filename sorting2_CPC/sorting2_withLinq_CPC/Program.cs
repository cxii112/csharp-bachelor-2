using System;
using System.Linq;

namespace sorting2_withLinq_CPC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите длину массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            RandomCase(N);
            BestCase(N);
            WorstCase(N);
        }

        private static void RandomCase(int n)
        {
            Console.WriteLine();
            Console.WriteLine("Случайное заполнение");
            int[] randomCase = InitWithRandom(n);
            int[] sorted = QSort(randomCase);
            Print(ref sorted, "Sorted");
        }

        private static void BestCase(int n)
        {
            Console.WriteLine();
            Console.WriteLine("\"Лучшее\" заполнение");
            int[] bestCase = InitWithBest(n);
            QSort(bestCase);
        }

        private static void WorstCase(int n)
        {
            Console.WriteLine();
            Console.WriteLine("\"Худшее\" заполнение");
            int[] worstCase = InitWithWorst(n);
            QSort(worstCase);
        }

        static int[] InitWithRandom(int size)
        {
            Random random = new Random();
            int[] result = new int[size];
            return result.Select(number => random.Next(-10, 20)).ToArray();
        }

        static int[] InitWithBest(int size)
        {
            int i = 0;
            int[] result = new int[size];
            return result.Select(number => i++).ToArray();
        }

        static int[] InitWithWorst(int size)
        {
            int i = size;
            int[] result = new int[size];
            return result.Select(number => i--).ToArray();
        }

        static int[] QSort(int[] source)
        {
            if (source.Length <= 1) return source;
            Print(ref source, "Исходный:");
            
            int pivot = source[(source.Length - 1) / 2];
            
            var minor = source.Where(i => i < pivot).ToArray();
            var major = source.Where(i => i > pivot).ToArray();
            
            minor = QSort(minor);
            major = QSort(major);
            
            var sorted = minor.Append(pivot).Concat(major).ToArray();
            
            Print(ref sorted, "Отсортированный:");
            return sorted;
        }

        static void Print(ref int[] source, string message = "")
        {
            message = message == "" ? message : message + " ";
            Console.WriteLine($"{message}{string.Join(", ", source)}");
        }
    }
}