using System;

namespace sorting2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[N];
            InitWithRandom(ref numbers);
            QSort(ref numbers, 0, numbers.Length - 1);
        }

        static void InitWithRandom(ref int[] destination)
        {
            Random random = new Random();
            for (int i = 0; i < destination.Length; i++)
            {
                destination[i] = random.Next(0, 20);
            }
        }
        static void QSort(ref int[] source, int from, int to)
        {
            Print(ref source, "Пришедший массив");
            int middleIndex = (from + to) / 2;
            int comparer = source[middleIndex];
            Console.WriteLine($"{comparer} @ {middleIndex}");
            int i = from, j = to;
            while (i <= j)
            {
                while (source[i] < comparer) i++;
                while (source[j] > comparer) j--;
                if (i <= j)
                {
                    Swap(ref source[i], ref source[j]);
                    i++;
                    j--;
                }
            }
            Print(ref source, $"Перемещение относительно {comparer}:");
            if (j > from) QSort(ref source, from, j);
            if (i < to) QSort(ref source, i, to);
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