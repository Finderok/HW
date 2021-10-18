using System;

namespace InheritanceAndPolymorphismEx6
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
