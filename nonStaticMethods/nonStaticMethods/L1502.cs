using System;

namespace nonStaticMethods
{
    internal sealed class L1502
    {
        public static void Main(string[] args)
        {
            // Example();
            Task1();
        }

        private static void Task1()
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            Triangle triangle = new Triangle();
            Console.WriteLine($"P = {triangle.Perimeter(a, b, c)}");
            Console.WriteLine($"S = {triangle.Area(a, b, c)}");
        }

        private static void Example()
        {
            int a = 1, b = 2, c = 1, d = 4;
            Fraction ob2 = new Fraction();
            ob2.Add(a, b, c, d);
            double R = ob2.Subtract(a, b, c, d);
            Console.WriteLine(" Разность дробей =" + R);
        }
    }

    public class Fraction
    {
        public void Add(int a, int b, int c, int d)
        {
            double s = (double)a / b + (double)c / d;
            Console.WriteLine($"{a}/{b} + {c}/{d} = {s}");
        }

        public double Subtract(int a, int b, int c, int d)
        {
            double R = (double)a / b - (double)c / d;
            Console.WriteLine($"{a}/{b} - {c}/{d} = {R}");
            return R;
        }
    }

    public class Triangle
    {
        public double Area(double a, double b, double c)
        {
            double p = Perimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}