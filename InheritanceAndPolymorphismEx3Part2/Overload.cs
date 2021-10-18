using System;

namespace InheritanceAndPolymorphismEx3Part2
{
    public class Overload
    {
        public void Display()
        {
            DisplayOverload(100, "200", "300");
            DisplayOverload(200, "100");

            string[] names = { "Akhil", "Ekta", "Arsh" };
            DisplayOverload(200, names);
        }

        private void DisplayOverload(int a, params string[] parameterArray)
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
        }
    }
}
