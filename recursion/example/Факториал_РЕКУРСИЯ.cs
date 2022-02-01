using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int FAKT_F(int n)
        {
            int F = 1;
            for (int i = 1; i <= n; i++) F *= i;
            return F;
        }
        static void FAKT_PR(int n, out int F4)
        {
            F4 = 1;
            for (int i = 1; i <= n; i++) F4 *= i;
        }

        static long FF(long n) //рекурсивный метод 
        { 
            if (n == 0 || n == 1)//нерекурсивная ветвь 
        {
            long rez = 1;//////////////////////////
                return rez; } 
            else 
            { 
                long rez = n * FF(n - 1);//шаг рекурсии - //вызов метода с другим параметром 
                return rez; 
            } 
        }

        static void Main(string[] args)
        {
            // -------  1. Вычисление ФАКТОРИАЛА - цикл for:
            int F1 = 1;
            for (int i = 1; i <= 5; i++) F1 = F1 * i;//F1 *= i;
            
            // -------  2. Вычисление ФАКТОРИАЛА - цикл for «без тела цикла»:
            int F2 = 1;
            for (int i = 1; i <= 5; F2 *= i++);

            //-------  3. Вычисление ФАКТОРИАЛА - МЕТОД-функция
                        Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());//вводим переменную от которй будем брать факториал
            int a = FAKT_F(n);
            Console.WriteLine("Факториал ="+a);
           
            //-------  4. Вычисление ФАКТОРИАЛА - МЕТОД-процедура
            Console.WriteLine("Введите n");
            n = Convert.ToInt32(Console.ReadLine());//вводим переменную от которй будем брать факториал
            int F4;
            FAKT_PR(n, out F4);
            Console.WriteLine("Факториал =" + F4);

            long f = FF(5);
            Console.WriteLine("Факториал =" + f);

        }
    }
}
