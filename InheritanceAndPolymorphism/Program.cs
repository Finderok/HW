using System;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {//Ex1
            var overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading", 100);
        
        }               
    }
}
