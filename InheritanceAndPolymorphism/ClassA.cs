using System;

namespace InheritanceAndPolymorphism
{
    class ClassA : ClassB
    {
        public void Display1()
        {
            Console.WriteLine("ClassA Display1");
            base.Display1();
        }
    }
}
