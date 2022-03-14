using System;

namespace constructors_CPC
{
    /**
     * Вариант №4
     * @author Дмитрий Ляховой ММТ-2-2021
     */
    internal sealed class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Вариант №4");
            Console.Write("Введите координаты начальной точки");
        }
    }

    internal class Vector
    {
        private int _x;
        private int _y;
        private int _z;

        // Стандартный конструктор
        Vector()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        Vector(int xStart, int yStart, int zStart,
               int xEnd,   int yEnd,   int zEnd)
        {
            _x = xEnd - xStart;
            _y = yEnd - yStart;
            _z = zEnd - zStart;
        }

        public Vector(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public Vector Subtract(Vector v)
        {
            int a = this._x - v._x;
            int b = this._y - v._y;
            int c = this._z - v._z;
            return new Vector(a, b, c);
        }
    }
}