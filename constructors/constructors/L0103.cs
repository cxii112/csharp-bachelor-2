using System;

namespace constructors
{
    /**
     * Вариант №4
     * @author Дмитрий Ляховой ММТ-2-2021
     */
    internal class L0103
    {
        public static void Main(string[] args)
        {
            Task1();
        }

        private static void Task1()
        {
            Console.WriteLine("Введите параметры треугольника (стороны)");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            Triangle defaultTriangle = new Triangle();
            Triangle pythagorianTriangle = new Triangle(3, 4, 5);
            Triangle customTriangle = new Triangle(a, b, c);
            
            Console.WriteLine($"Площадь треугольника (со сторонами 1): {defaultTriangle.Area()} ");
            Console.WriteLine($"Периметр треугольника (со сторонами 1): {defaultTriangle.Perimeter()} ");
            Console.WriteLine($"Площадь пифагорового треугольника (со сторонами 3, 4, 5): {pythagorianTriangle.Area()} ");
            Console.WriteLine($"Периметр пифагорового треугольника (со сторонами 3, 4, 5): {pythagorianTriangle.Perimeter()} ");
            Console.WriteLine($"Площадь заданного треугольника (со сторонами {a}, {b}, {c}): {customTriangle.Area()} ");
            Console.WriteLine($"Периметр заданного треугольника (со сторонами {a}, {b}, {c}): {customTriangle.Perimeter()} ");
        }
        // Тесты
        
        // a = 2
        // b = 2
        // c = 2
        // Площадь треугольника (со сторонами 1): 0,433012701892219
        // Периметр треугольника (со сторонами 1): 3
        // Площадь пифагорового треугольника (со сторонами 3, 4, 5): 6
        // Периметр пифагорового треугольника (со сторонами 3, 4, 5): 12
        // Площадь заданного треугольника (со сторонами 2, 2, 2): 1,73205080756888
        // Периметр заданного треугольника (со сторонами 2, 2, 2): 6
        
        // a = 1
        // b = 2
        // c = 3
        // Площадь треугольника (со сторонами 1): 0,433012701892219
        // Периметр треугольника (со сторонами 1): 3
        // Площадь пифагорового треугольника (со сторонами 3, 4, 5): 6
        // Периметр пифагорового треугольника (со сторонами 3, 4, 5): 12
        // Площадь заданного треугольника (со сторонами 1, 2, 3): 0
        // Периметр заданного треугольника (со сторонами 1, 2, 3): 6

    }

    public class Triangle
    {
        // Стороны треугольника
        private double _a;
        private double _b;
        private double _c;

        // Стандартный треугольник
        public Triangle()
        {
            _a = 1;
            _b = 1;
            _c = 1;
        }

        // Пользовательский треугольник
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        // Площадь треугольника
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        // Периметр треугольника
        public double Perimeter()
        {
            return _a + _b + _c;
        }
    }
}