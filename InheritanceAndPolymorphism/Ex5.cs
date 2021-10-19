﻿using System;

namespace InheritanceAndPolymorphism
{
    class Ex5
    {
        public void Display()
        {
            DisplayOverload(200);
            DisplayOverload(200, 300);
            DisplayOverload(200, 300, 500, 600);
        }

        private void DisplayOverload(int x, int y)
        {
            Console.WriteLine("The two integers " + x + " " + y);
        }

        private void DisplayOverload(params int[] parameterArray)
        {
            Console.WriteLine("parameterArray");
        }
    }
}
