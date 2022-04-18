using System;

namespace sorting2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите длину массива");
            int N = Convert.ToInt32(Console.ReadLine());
            Point[] numbers = new Point[N];
            InitWithRandom(ref numbers);
            QSortByX(ref numbers, 0, numbers.Length - 1);
        }

        static void InitWithRandom(ref Point[] destination)
        {
            Random random = new Random();
            for (int i = 0; i < destination.Length; i++)
            {
                int x = random.Next(-3, 3);
                int y = random.Next(-3, 3);
                destination[i] = new Point(x, y);
            }
        }

        static void QSortByX(ref Point[] source, int from, int to)
        {
            Print(ref source, "Пришедший массив");
            int middleIndex = (from + to) / 2;
            int comparer = source[middleIndex].X;
            Console.WriteLine($"{comparer} @ {middleIndex}");
            int i = from, j = to;
            while (i <= j)
            {
                while (source[i].X < comparer) i++;
                while (source[j].X > comparer) j--;
                if (i <= j)
                {
                    Swap(ref source[i], ref source[j]);
                    i++;
                    j--;
                }
            }
            Print(ref source, $"Перемещение относительно {comparer}:");
            if (j > from) QSortByX(ref source, from, j);
            if (i < to) QSortByX(ref source, i, to);
        }

        static void Swap(ref Point a, ref Point b)
        {
            Point temp = a;
            a = b;
            b = temp;
        }

        static void Print(ref Point[] source, string message = "")
        {
            message = message == "" ? message : message + " ";
            Console.WriteLine($"{message}{string.Join(", ", (object[])source)}");
        }
    }

    internal class Point
    {
        private int _x;

        private int _y;

        public int X => _x;

        public int Y => _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"({_x},{_y})";
        }
    }
}