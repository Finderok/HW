using System;

namespace HomeWorkP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic operations.
            // Ex 1.
            int x1 = 1;
            int y1 = x1 + 2;
            Console.WriteLine("Ex1 " + y1);
            // Ex 2.
            int x2 = 3;
            int y2 = x2 - 2;
            Console.WriteLine("Ex2 " + y2);
            // Ex 3.
            int x3 = 4;
            int z3 = 2;
            int y3 = x3 * z3;
            Console.WriteLine("Ex3 " + y3);
            // Ex 4.
            double x4 = 6;
            double z4 = 4;
            double y4 = x4 / z4;
            Console.WriteLine("Ex4 " + y4);
            // Ex 5.
            double x5 = 5;
            double y5 = x5 % 2;
            Console.WriteLine("Ex5 " + y5);
            // Ex 6.
            int x6 = 4;
            Console.WriteLine("Ex6 " + ++x6);
            // Ex 7.
            int x7 = 6;
            Console.WriteLine("Ex7 " + --x7);
            // Logical operations.
            // Ex 8.
            bool a = false;
            Console.WriteLine("Ex8 " + !a);
            // Ex 9.
            bool x8 = (1 > 2) | (2 < 3);
            bool x9 = (1 > 2) | (2 > 3);
            Console.WriteLine("Ex10 " + x8);
            Console.WriteLine(x9);
            // Ex 10.
            int d = 1;
            int e = 2;
            int d1 = 3;
            int e1 = 4;
            bool f = (d == e) && (d1 != e1);
            bool g = (d != e) && (d1 != e1);
            Console.WriteLine("Ex10 " + f);
            Console.WriteLine(g);
            // Ex 11.
            int b3 = 2;
            object check = 3.1;
            if (check is int b4)
            {
                Console.WriteLine("Ex11 " + b3 + b4);
            }
            else
            {
                Console.WriteLine("Ex11 Error");
            }
        }
    }
}
