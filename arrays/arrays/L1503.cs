using System;

namespace arrays
{
    internal class L1503
    {
        public static void Main(string[] args)
        {
            const int N = 5; // размерность массива
            int[] keyboardArray = new int[N];
            InitWithKeyboard(ref keyboardArray);
            Print(keyboardArray);
            
            int[] randomArray = new int[N];
            InitWithRandom(ref randomArray);
            Print(randomArray);
            
            int[] formulaArray = new int[N];
            InitWithFormula(ref formulaArray);
            Print(formulaArray);
            
            Find(0, keyboardArray);
            Find(0, randomArray);
            Find(0, formulaArray);
        }

        private static void InitWithKeyboard(ref int[] dest)
        {
            Console.WriteLine("Инициализация массива с клавиатуры");
            for (int i = 0; i < dest.Length; i++)
            {
                Console.Write($"Введите {i}-ый элемент ");
                dest[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void InitWithRandom(ref int[] dest)
        {
            Console.WriteLine("Инициализация с помощью случайных значений");
            Random random = new Random();
            for (int i = 0; i < dest.Length; i++)
            {
                dest[i] = random.Next();
            }
        }

        private static void InitWithFormula(ref int[] dest)
        {
            Console.WriteLine("Инициализация массива с использованием формулы i * 2");
            for (int i = 0; i < dest.Length; i++)
            {
                dest[i] = i * 2;
            }
        }

        private static void Print(int[] source)
        {
            Console.Write("[");
            foreach (int i in source)
            {
                Console.Write($"{i}, ");
            }
            Console.Write("]");
        }

        private static void Find(int element, int[] inArray)
        {
            bool isFound = false;
            for (int i = 0; i < inArray.Length && !isFound; i++)
            {
                if (inArray[i] == element) isFound = true;
            }

            if (isFound)
            {
                Console.WriteLine($"{element} существует в массиве");
            }
            else
            {
                Console.WriteLine($"{element} не существует в массиве");
            }
        }
    }
}