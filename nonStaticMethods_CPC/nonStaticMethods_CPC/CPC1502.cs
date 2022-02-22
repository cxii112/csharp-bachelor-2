using System;

namespace nonStaticMethods_CPC
{
    /**
     * Вариант №4
     * @author Дмитрий Ляховой ММТ-2-2021
     */
    internal sealed class CPC1502
    {
        public static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        private static void Task1()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            // новый объект, отвечающий за последовательности
            Serials s = new Serials();
            // вызов s.Sum() с фактическим параметром n
            Console.WriteLine($"1! + 2! + .. + n! = {s.Sum(n)}");
        }
        // Тесты для Задания 1
        // n = 4
        // 1! + 2! + .. + n! = 33

        // n = 1
        // 1! + 2! + .. + n! = 1

        private static void Task2()
        {
            Console.WriteLine("Вариант #4");
            Console.Write("x0 = ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y0 = ");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("R = ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выстрел:");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            // новый объект, отвечающий за окружность
            Circle circle = new Circle();
            // вызов circle.Length() и circle.Area()
            // с фактическим параметром R
            Console.WriteLine($"l = {circle.Length(R)}");
            Console.WriteLine($"S = {circle.Area(R)}");
            circle.MakeShot(x0, y0, R,
                            x, y);
        }
        // Тесты для Задания 2
        // Вариант #4
        // x0 = 0
        // y0 = 0
        // R = 2
        // Выстрел:
        // x = 1
        // y = 1
        // l = 12,5663706143592
        // S = 12,5663706143592
        // Выстрел в (1,1) в окружность с центром (0,0) радиуса 2
        // Попал

        // Вариант #4
        // x0 = 0
        // y0 = 0
        // R = 4
        // Выстрел:
        // x = -1
        // y = 2
        // l = 25,1327412287183
        // S = 50,2654824574367
        // Выстрел в (-1,2) в окружность с центром (0,0) радиуса 4
        // Попал
    }

    internal class Serials
    {
        private long Factorial(int n)
        {
            if (n == 1) return 1; // не рекурентная ветвь
            // рекурсивно считаем факториал
            return n * Factorial(n - 1);
        }

        public long Sum(int n)
        {
            if (n <= 1) return 1; // не рекурентная ветвь
            // разбиваем ряд на 2 слагаемых:
            // N! и сумму ряда (N - 1)
            return Factorial(n) + Sum(n - 1);
        }
    }

    internal class Circle
    {
        internal double Area(double R)
        {
            double area = Math.PI * R * R;
            return area;
        }

        internal double Length(double R)
        {
            double length = 2 * Math.PI * R;
            return length;
        }

        /// <summary>
        /// Производит выстрел по мишени-окружности, заданной уравнением.
        /// </summary>
        /// <param name="x0">x-координата центра</param>
        /// <param name="y0">y-координата центра</param>
        /// <param name="R">радиус окружности</param>
        /// <param name="x">x-координата выстрела</param>
        /// <param name="y">y-координата выстрела</param>
        public void MakeShot(double x0, double y0, double R,
                             double x,  double y)
        {
            Console.WriteLine($"Выстрел в ({x},{y}) в окружность с центром ({x0},{y0}) радиуса {R}");
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) <= R * R)
            {
                Console.WriteLine("Попал");
            }
            else
            {
                Console.WriteLine("Не попал");
            }
        }
    }
}