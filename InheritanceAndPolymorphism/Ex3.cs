using System;

namespace InheritanceAndPolymorphism
{
    class Ex3
    {
        public void Display()
        {
            DisplayOverload1(100, 200, 300);
            DisplayOverload1(200, 100);
            DisplayOverload1(200);
        }

        private void DisplayOverload1(int a, params int[] parameterArray)
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
        }
        public void Display2()
        {
            DisplayOverload2(100, "200", "300");
            DisplayOverload2(200, "100");

            string[] names = { "Akhil", "Ekta", "Arsh" };
            DisplayOverload2(200, names);
        }

        private void DisplayOverload2(int a, params string[] parameterArray)
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
        }
    }
}
