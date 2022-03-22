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
            // TaskCPC8();
            Console.WriteLine("Введите стороны прямоугольника");
            Console.Write("a = ");
            uint a = Convert.ToUInt32(Console.ReadLine());
            Console.Write("b = ");
            uint b = Convert.ToUInt32(Console.ReadLine());
            Rectangle rectangle = new Rectangle(a, b);
            Console.WriteLine($"Периметр прямоугольника со сторонами {a},{b} равен {rectangle.Perimeter()}");
        }
        
        // Вариант №4
        // Введите стороны прямоугольника
        // a = 1
        // b = 2
        // Периметр прямоугольника со сторонами 1,2 равен 6
        
        // Вариант №4
        // Введите стороны прямоугольника
        // a = 3
        // b = 5
        // Периметр прямоугольника со сторонами 3,5 равен 16



        private static void TaskCPC8()
        {
            Console.WriteLine("Введите координаты начальной точки");
            Console.Write("x = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты конечной точки");
            Console.Write("x = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = ");
            int z2 = Convert.ToInt32(Console.ReadLine());

            Vector defaultVector = new Vector();
            Vector userVector = new Vector(1, 2, 3);
            Vector pointsVector = new Vector(x1, y1, z1,
                                             x2, y2, z2);
            Console.WriteLine($"Стандартный вектор {defaultVector}");
            Console.WriteLine($"Вектор заданный одной координатой {userVector}");
            Console.WriteLine($"Вектор заданный 2-мя координатами {pointsVector}");
            Console.WriteLine($"{defaultVector} - {pointsVector} = {defaultVector.Subtract(pointsVector)}");
        }

        //     Вариант №4
    //     Введите координаты начальной точкиx = 0
    //     y = 0
    //     z = 1
    //     Введите координаты конечной точкиx = 2
    //     y = 2
    //     z = 2
    //     Стандартный вектор {0, 0, 0}
    //     Вектор заданный одной координатой {1, 2, 3}
    //     Вектор заданный 2-мя координатами {2, 2, 1}
    
    // Вариант №4
    // Введите координаты начальной точки
    // x = -1
    // y = -1
    // z = -1
    // Введите координаты конечной точки
    // x = 3
    // y = -7
    // z = 0
    // Стандартный вектор {0, 0, 0}
    // Вектор заданный одной координатой {1, 2, 3}
    // Вектор заданный 2-мя координатами {4, -6, 1}
    }

    internal class Vector
    {
        private int _x; // x-вая координата вектора
        private int _y; // y-вая координата вектора
        private int _z; // z-ая координата вектора

        // Стандартный конструктор
        public Vector()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        // Конструктора из координат 2х точек
        public Vector(int xStart, int yStart, int zStart,
               int xEnd,   int yEnd,   int zEnd)
        {
            _x = xEnd - xStart;
            _y = yEnd - yStart;
            _z = zEnd - zStart;
        }

        // Конструктор задающий вектр по его координатам
        public Vector(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        // Вычитание векторов
        public Vector Subtract(Vector v)
        {
            int a = this._x - v._x;
            int b = this._y - v._y;
            int c = this._z - v._z;
            return new Vector(a, b, c);
        }

        public override string ToString()
        {
            return $"{{{_x}, {_y}, {_z}}}";
        }
    }

    internal class Rectangle
    {
        private uint _a;
        private uint _b;
        public Rectangle(uint a, uint b)
        {
            _a = a;
            _b = b;
        }

        public uint Perimeter()
        {
            return 2 * (_a + _b);
        }
    }
}