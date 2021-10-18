using System;

namespace InheritanceAndPolymorphismEx2
{
    public class Overload
    {   //part1
        private string name = "Akhil";
        public void Display()
        {
            Display2(ref name, ref name);
            Console.WriteLine(name);
        }

        public void Display2(ref string x, ref string y)
        {
            Console.WriteLine(name);
            x = "Akhil 1";
            Console.WriteLine(name);
            y = "Akhil 2";
            Console.WriteLine(name);
            name = "Akhil 3";
        }
        //part2
        public void Display3()
        {
            DisplayOverload(100, "Akhil", "Mittal", "OOP");
            DisplayOverload(200, "Akhil");
            DisplayOverload(300);
        }

        private void DisplayOverload(int a, params string[] parameterArray)
        {
            foreach (string str in parameterArray)
                Console.WriteLine(str + " " + a);
        }
    }
}
