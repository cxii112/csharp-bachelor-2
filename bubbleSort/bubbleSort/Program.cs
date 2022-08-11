using System;

namespace bubbleSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = InitWithRandom(10);
            Sort(ref numbers);
        }

        private static int[] InitWithRandom(int count)
        {
            int[] numbers = new int[count];

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-5, 5);
            }
            
            return numbers;
        }
        private static void Sort(ref int[] source)
        {
            int comparasions = 0;
            int swaps = 0;
            for (int i = 1; i < source.Length; i++)
            {
                for (int j = 0; j < source.Length - i; j++)
                {
                    comparasions++;
                    if (source[j] > source[j + 1])
                    {
                        swaps++;
                        int temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
                Print(ref source,  $"перестановок: {swaps,4}, сравнений: {comparasions,4}");
            }
        }

        private static void Print(ref int[] source, string message = "")
        {
            message = message == "" ? message : " " + message;
            Console.WriteLine($"[{string.Join(", ", source)}]{message}");
        }
    }
}