using System;

namespace InheritanceAndPolymorphism
{
    class Ex1
    {
        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload: {a}");
        }

        public void DisplayOverload(string a)
        {
            Console.WriteLine($"DisplayOverload: {a}");
        }

        public void DisplayOverload(string a, int b)
        {
            Console.WriteLine($"DisplayOverload: {a} {b}");
        }
    }
}
