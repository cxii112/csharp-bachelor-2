using System;

namespace recursion_2
{
    internal class L0102_2
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите стартовую \"ступеньку\" ");
            int start_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечную \"ступеньку\" ");
            int end_1 = Convert.ToInt32(Console.ReadLine());
            PrintLadder(start_1, end_1);
            
            Console.Write("Введите стартовую \"ступеньку\" ");
            int start_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечную \"ступеньку\" ");
            int end_2 = Convert.ToInt32(Console.ReadLine());
            PrintNumbersLadder(start_2, end_2);
        }

        private static void PrintLadder(int from, int to)
        {
            for (int i = 0; i < from; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            if (from < to) PrintLadder(from + 1, to);
        }

        private static void PrintNumbersLadder(int from, int to)
        {
            for (int i = 0; i < from; i++)
            {
                Console.Write($"{from}");
            }

            Console.WriteLine();
            if (from < to) PrintNumbersLadder(from + 1, to);
        }
    }
}