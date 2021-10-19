using System;

namespace InheritanceAndPolymorphism
{
    class Ex4
    {
        public void Display()
        {
            int[] numbers = { 10, 20, 20 };
            DisplayOverload1(40, numbers);
            Console.WriteLine(numbers[1]);
        }
        private void DisplayOverload1(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }

        public void Display2()
        {
            int number = 102;
            DisplayOverload2(40, 1000, number, 4000);
            Console.WriteLine(number);
        }

        private void DisplayOverload2(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }
    }
}
