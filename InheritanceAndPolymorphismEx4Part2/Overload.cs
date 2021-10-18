using System;

namespace InheritanceAndPolymorphismEx4Part2
{
    public class Overload
    {
        public void Display()
        {
            int number = 102;
            DisplayOverload(40, 1000, number, 4000);
            Console.WriteLine(number);
        }

        private void DisplayOverload(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }
    }
}
