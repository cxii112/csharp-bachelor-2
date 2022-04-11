using System;

namespace sorting
{
    internal class L2903
    {
        // 1. Сортировка элементов массива по возрастанию,
        //    в виде отдельного метода SORT.
        //    (Вызов метода осуществляется из метода Main).
        //    В методе сортировки обеспечьте:
        //          а) подсчет количества сравнений ( KS) и подсчет количества пересылок (KP);
        //          b) вывод KS и KP в методе сортировки.
        // 2. Просмотр изменений в массиве после каждого шага сортировки.
        // 3. Сортировка по убыванию элементов массива, с четными индексами,
        // в виде отдельного метода SORT_1. (Вызов метода осуществляется из метода Main).
        public static void Main(string[] args)
        {
            int N = 10;
            
            Console.WriteLine("Сортировка простыми вставками");
            int[] numbers = new int[N];
            InitWithRandom(ref numbers);
            Print(ref numbers, "Исходный массив");
            Sort(ref numbers);
            Print(ref numbers, "Полученный массив");

            Console.WriteLine("Сортировка простым выбором");
            int[] numbersReverse = new int[N];
            InitWithRandom(ref numbersReverse);
            Print(ref numbersReverse, "Исходный массив");
            Sort_1(ref numbersReverse);
            Print(ref numbersReverse, "Полученный массив");
        }

        private static void InitWithRandom(ref int[] destination)
        {
            Random random = new Random();
            for (int i = 0; i < destination.Length; i++)
            {
                destination[i] = destination.Length - i;
            }
        }

        private static void Sort(ref int[] source)
        {
            int KS = 0;
            int KP = 0;
            for (int j = 1; j < source.Length; j++)
            {
                int i = j - 1;
                int wr = source[j];
                KS++;
                while ((i >= 0) && (source[i] > wr))
                {
                    source[i + 1] = source[i];
                    i--;
                    KS++;
                    KP++;
                }

                source[i + 1] = wr;
                KP += 2;
                
                Print(ref source, $"KS={KS}, KP={KP}");
            }
        }

        private static void Sort_1(ref int[] source)
        {
            int KS = 0;
            int KP = 0;
            for (int j = source.Length - 1; j >= 1; j--) //Просмотр массива для поиска максимума
            {
                int max = source[j]; //начальное значение максимума в рассматриваемой части массива
                int k = j; // начальное значение номера максимума в рассматриваемой части массива
                for (int i = 0; i < j; i++) // поиск элемента большего чем максимум
                {
                    if (source[i] > max)
                    {
                        max = source[i]; // найден больший элемент чем максимум
                        k = i; // фиксируется номер максимума
                        KP++;
                    }

                    KS++;
                } // перестановка элементов
                source[k] = source[j];
                source[j] = max;
                KP += 3;
                Print(ref source, $"KS={KS}, KP={KP}");
            }
        }

        private static void Print(ref int[] source, string message = "")
        {
            Console.WriteLine($"{message} {string.Join(", ", source)}");
        }
    }
}