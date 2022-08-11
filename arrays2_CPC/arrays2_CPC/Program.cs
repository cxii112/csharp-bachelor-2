using System;
using System.IO;

namespace arrays2_CPC
{
    /**
     * @author Дмитрий Ляховой ММТ-2-2021
     * Вариант №4
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            string inputPath = $@"{args[0]}";
            string outputPath = $@"{args[1]}out.txt";
            MASSIV_4 customArray = new MASSIV_4(5, inputPath, outputPath);
            customArray.Read();
            Console.WriteLine($"Полученный массив: {customArray}");

            customArray.Remove44();
            Console.WriteLine($"Без 44: {customArray}");

            Console.Write("Введите элемент, после которого надо удалить оставшиеся ");
            int K4 = Convert.ToInt32(Console.ReadLine());
            customArray.RemoveAllAfter(K4);
            Console.WriteLine($"Обрезанный массив: {customArray}");

            customArray.MakeCirclePermutations();
            Console.WriteLine($"Массив после цикличного сдвига: {customArray}");

            customArray.Write();
        }
    }

    // Задание
    // Разработать отдельный класс MASSIV_4 для работы с одномерным массивом целочисленных элементов.
    // Элементы класса:
    //      Поля: N4 – размерность массива;
    //      Методы:
    //          * +++   заполнение элементов массива из файла (см. Пример 6);
    //              предусмотрите наличие в файле значений элементов массива,
    //              необходимых для реализации методов;
    //          * +++   вывод массива на экран;
    //          * +++   удаление всех элементов массива,
    //              расположенных после элемента со значением К4,
    //              введенного с клавиатуры;
    //          * +++   удаление элемента массива со значением 44;
    //          * +++   реализация циклического сдвига элементов массива влево на 6 элементов;
    //          * +++   запись измененного массива в новый файл (см. Приложение 2).
    // Модификаторы доступа для полей определите самостоятельно.
    // Модификаторы доступа для методов должны обеспечить
    // доступ ко всем методам из любого метода любого класса программы.
    // Класс Program обязательно должен содержать объявление (описание) массива.

    internal class MASSIV_4
    {
        public MASSIV_4(int n4, string inputFile, string outputFile = @"./out.txt")
        {
            N4 = n4;
            InputFile = inputFile;
            OutputFile = outputFile;
            Numbers = new int[N4];
        }

        public void Read()
        {
            using (StreamReader inputStream = File.OpenText(InputFile))
            {
                string[] strings = inputStream.ReadToEnd()
                                              .Split(',');
                Numbers = new int[N4];
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(strings[i]);
                }
            }
        }

        public void Write()
        {
            using (StreamWriter outputStream = File.CreateText(OutputFile))
            {
                var @join = string.Join(",", Numbers);
                outputStream.Write(@join);
            }
        }

        public void RemoveAllAfter(int borderIndex)
        {
            int[] newNumbers = new int[Numbers.Length - borderIndex];
            for (int i = 0; i < newNumbers.Length; i++)
            {
                newNumbers[i] = Numbers[i];
            }

            Numbers = newNumbers;
        }

        public void Remove44()
        {
            int indexOf44 = -1;
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] != 44) continue;
                indexOf44 = i;
            }

            // выход если нет 44
            if (indexOf44 == -1) return;
            int[] newNumbers = new int[Numbers.Length - 1];
            for (int i = 0; i < indexOf44; i++)
            {
                newNumbers[i] = Numbers[i];
            }

            for (int i = indexOf44; i < Numbers.Length - 1; i++)
            {
                newNumbers[i] = Numbers[i + 1];
            }
        }

        public void MakeCirclePermutations()
        {
            for (int i = 0; i < 6; i++)
            {
                int temp = Numbers[0];
                for (int j = 0; j < Numbers.Length - 1; j++)
                {
                    Numbers[j] = Numbers[j + 1];
                }

                Numbers[Numbers.Length - 1] = temp;
            }
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", Numbers)}]";
        }

        public int N4 { get; }
        public string InputFile { get; }
        public string OutputFile { get; }

        private int[] Numbers { get; set; }
    }
}