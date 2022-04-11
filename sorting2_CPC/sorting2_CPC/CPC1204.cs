using System;
using System.Linq;

namespace sorting2
{
    internal class CPC1204
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите длину массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            RandomCase(N);
            Console.WriteLine();
            BestCase(N);
            Console.WriteLine();
            WorstCase(N);
        }
        
        // Введите длину массива 5
        //
        // Случайное заполнение
        // Пришедший массив 13, 15, 10, 5, -8
        // Перемещение относительно 10 @ 2: -8, 5, 10, 15, 13
        // сравнений:    6, перемещений:    3
        // Пришедший массив -8, 5, 10, 15, 13
        // Перемещение относительно -8 @ 0: -8, 5, 10, 15, 13
        // сравнений:    9, перемещений:    4
        // Пришедший массив -8, 5, 10, 15, 13
        // Перемещение относительно 15 @ 3: -8, 5, 10, 13, 15
        // сравнений:   11, перемещений:    5
        //
        // "Лучшее" заполнение
        //     Пришедший массив 0, 1, 2, 3, 4
        // Перемещение относительно 2 @ 2: 0, 1, 2, 3, 4
        // сравнений:    6, перемещений:    1
        // Пришедший массив 0, 1, 2, 3, 4
        // Перемещение относительно 0 @ 0: 0, 1, 2, 3, 4
        // сравнений:    9, перемещений:    2
        // Пришедший массив 0, 1, 2, 3, 4
        // Перемещение относительно 3 @ 3: 0, 1, 2, 3, 4
        // сравнений:   12, перемещений:    3
        //
        // "Худшее" заполнение
        //     Пришедший массив 5, 4, 3, 2, 1
        // Перемещение относительно 3 @ 2: 1, 2, 3, 4, 5
        // сравнений:    6, перемещений:    3
        // Пришедший массив 1, 2, 3, 4, 5
        // Перемещение относительно 1 @ 0: 1, 2, 3, 4, 5
        // сравнений:    9, перемещений:    4
        // Пришедший массив 1, 2, 3, 4, 5
        // Перемещение относительно 4 @ 3: 1, 2, 3, 4, 5
        // сравнений:   12, перемещений:    5

        
        // Введите длину массива 3
        //
        // Случайное заполнение
        // Пришедший массив -4, 14, 13
        // Перемещение относительно 14 @ 1: -4, 13, 14
        // сравнений:    3, перемещений:    1
        // Пришедший массив -4, 13, 14
        // Перемещение относительно -4 @ 0: -4, 13, 14
        // сравнений:    6, перемещений:    2
        //
        // "Лучшее" заполнение
        //     Пришедший массив 0, 1, 2
        // Перемещение относительно 1 @ 1: 0, 1, 2
        // сравнений:    4, перемещений:    1
        //
        // "Худшее" заполнение
        //     Пришедший массив 3, 2, 1
        // Перемещение относительно 2 @ 1: 1, 2, 3
        // сравнений:    4, перемещений:    2

        
        // Введите длину массива 6
        //
        // Случайное заполнение
        // Пришедший массив -2, -6, 1, 15, 19, -2
        // Перемещение относительно 1 @ 2: -2, -6, -2, 15, 19, 1
        // сравнений:    8, перемещений:    1
        // Пришедший массив -2, -6, -2, 15, 19, 1
        // Перемещение относительно -6 @ 1: -6, -2, -2, 15, 19, 1
        // сравнений:   11, перемещений:    2
        // Пришедший массив -6, -2, -2, 15, 19, 1
        // Перемещение относительно -2 @ 1: -6, -2, -2, 15, 19, 1
        // сравнений:   13, перемещений:    3
        // Пришедший массив -6, -2, -2, 15, 19, 1
        // Перемещение относительно 19 @ 4: -6, -2, -2, 15, 1, 19
        // сравнений:   16, перемещений:    4
        // Пришедший массив -6, -2, -2, 15, 1, 19
        // Перемещение относительно 15 @ 3: -6, -2, -2, 1, 15, 19
        // сравнений:   18, перемещений:    5
        //
        // "Лучшее" заполнение
        //     Пришедший массив 0, 1, 2, 3, 4, 5
        // Перемещение относительно 2 @ 2: 0, 1, 2, 3, 4, 5
        // сравнений:    7, перемещений:    1
        // Пришедший массив 0, 1, 2, 3, 4, 5
        // Перемещение относительно 0 @ 0: 0, 1, 2, 3, 4, 5
        // сравнений:   10, перемещений:    2
        // Пришедший массив 0, 1, 2, 3, 4, 5
        // Перемещение относительно 4 @ 4: 0, 1, 2, 3, 4, 5
        // сравнений:   14, перемещений:    3
        //
        // "Худшее" заполнение
        //     Пришедший массив 6, 5, 4, 3, 2, 1
        // Перемещение относительно 4 @ 2: 1, 2, 3, 4, 5, 6
        // сравнений:    6, перемещений:    3
        // Пришедший массив 1, 2, 3, 4, 5, 6
        // Перемещение относительно 2 @ 1: 1, 2, 3, 4, 5, 6
        // сравнений:   10, перемещений:    4
        // Пришедший массив 1, 2, 3, 4, 5, 6
        // Перемещение относительно 5 @ 4: 1, 2, 3, 4, 5, 6
        // сравнений:   14, перемещений:    5

        private static void RandomCase(int N)
        {
            Console.WriteLine("Случайное заполнение");
            int[] randomCase = InitWithRandom(N);
            int countedComparisons = 0;
            int countedSwaps = 0;
            QSort(ref randomCase, ref countedComparisons, ref countedSwaps);
        }

        private static void BestCase(int N)
        {
            int countedComparisons = 0;
            int countedSwaps = 0;
            Console.WriteLine("\"Лучшее\" заполнение");
            int[] bestCase = InitWithBest(N);
            QSort(ref bestCase, ref countedComparisons, ref countedSwaps);
        }

        private static void WorstCase(int N)
        {
            int countedComparisons = 0;
            int countedSwaps = 0;
            Console.WriteLine("\"Худшее\" заполнение");
            int[] worstCase = InitWithWorst(N);
            QSort(ref worstCase, ref countedComparisons, ref countedSwaps);
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

        static void QSort(ref int[] source,
                          ref int   countedComparisons,
                          ref int   countedSwaps,
                          int       from = 0, int to = -1)
        {
            to = to == -1 ? source.Length - 1 : to;

            Print(ref source, "Пришедший массив");

            int pivotIndex = (from + to) / 2;
            int pivot = source[pivotIndex];

            int i = from, j = to;
            while (i <= j)
            {
                while (source[i] < pivot)
                {
                    i++;
                    countedComparisons++;
                }

                countedComparisons++;

                while (source[j] > pivot)
                {
                    j--;
                    countedComparisons++;
                }

                countedComparisons++;

                if (i <= j)
                {
                    Swap(ref source[i], ref source[j]);
                    countedSwaps++;
                    i++;
                    j--;
                }
            }

            Print(ref source, $"Перемещение относительно {pivot} @ {pivotIndex}:");
            Console.WriteLine($"сравнений: {countedComparisons,4}, перемещений: {countedSwaps,4}");

            if (j > from)
                QSort(ref source,
                      ref countedComparisons, ref countedSwaps,
                      from, j);

            if (i < to)
                QSort(ref source,
                      ref countedComparisons, ref countedSwaps,
                      i, to);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Print(ref int[] source, string message = "")
        {
            message = message == "" ? message : message + " ";
            Console.WriteLine($"{message}{string.Join(", ", source)}");
        }
    }
}