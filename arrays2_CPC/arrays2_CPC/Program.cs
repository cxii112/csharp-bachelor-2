using System;
using System.IO;
using System.Linq;

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
            MASSIV_4 customArray = new MASSIV_4(10, inputPath, outputPath);
            customArray.Read();
            Console.WriteLine($"Полученный массив: {customArray}");
            
            customArray.Remove44();
            Console.WriteLine($"Без 44: {customArray}");
            
            Console.Write("Введите элемент, после которого надо удалить оставшиеся ");
            int borderNumber = Convert.ToInt32(Console.ReadLine());
            customArray.RemoveAllAfter(borderNumber);
            Console.WriteLine($"Обрезанный массив: {customArray}");
            
            customArray.MakeCirclePermutations();
            Console.WriteLine($"Массив после цикличного сдвига: {customArray}");
            
            customArray.Write();
        }
        // Полученный массив: [44, 123, -34, 12523, 2532, 4574, -924, 340, -904, 1]
        // Без 44: [123, -34, 12523, 2532, 4574, -924, 340, -904, 1]
        // Введите элемент, после которого надо удалить оставшиеся 4574
        // Обрезанный массив: [123, -34, 12523, 2532, 4574]
        // Массив после цикличного сдвига: [-34, 12523, 2532, 4574, 123]

        
        // Полученный массив: [44, 123, -34, 12523, 2532, 4574, -924, 340, -904, 1]
        // Без 44: [123, -34, 12523, 2532, 4574, -924, 340, -904, 1]
        // Введите элемент, после которого надо удалить оставшиеся -924
        // Обрезанный массив: [123, -34, 12523, 2532, 4574, -924]
        // Массив после цикличного сдвига: [123, -34, 12523, 2532, 4574, -924]

        
        // Полученный массив: [44, 123, -34, 12523, 2532, 4574, -924, 340, -904, 1]
        // Без 44: [123, -34, 12523, 2532, 4574, -924, 340, -904, 1]
        // Введите элемент, после которого надо удалить оставшиеся 12523
        // Обрезанный массив: [123, -34, 12523]
        // Массив после цикличного сдвига: [123, -34, 12523]
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
                Numbers = inputStream.ReadLine()
                                     .Split(',')
                                     .Take(N4)
                                     .Select(numberString => int.Parse(numberString))
                                     .ToArray();
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

        public void RemoveAllAfter(int after)
        {
            Numbers = Numbers.TakeWhile(number => number != after)
                             .Append(after)
                             .ToArray();
        }

        public void Remove44()
        {
            Numbers = Numbers.Where(number => number != 44)
                             .ToArray();
        }

        public void MakeCirclePermutations()
        {
            for (int i = 0; i < 6; i++)
            {
                Numbers = Numbers.Skip(1).Append(Numbers[0]).ToArray();
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