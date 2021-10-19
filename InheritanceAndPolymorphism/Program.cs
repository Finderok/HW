using System;

namespace InheritanceAndPolymorphism
{    //Ex7
    public class ClassC
    {
        public virtual void XXX()
        {
            Console.WriteLine("ClassC XXX");
        }
    }

    public abstract class ClassD : ClassC
    {
        public new abstract void XXX();
    }

    public class ClassE : ClassD
    {
        public override void XXX()
        {
            Console.WriteLine("ClassD XXX");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {//Ex1 
            Console.WriteLine("Ex1");
            var overload1 = new Ex1();
            overload1.DisplayOverload(100);
            overload1.DisplayOverload("method overloading");
            overload1.DisplayOverload("method overloading", 100);
         //Ex2
            Console.WriteLine("Ex2");
            var overload2 = new Ex2();
            overload2.Display();
            overload2.Display3();
         //Ex3
            Console.WriteLine("Ex3");
            var overload3 = new Ex3();
            overload3.Display();
            overload3.Display2();
         //Ex4
            Console.WriteLine("Ex4");
            var overload4 = new Ex4();
            overload4.Display();
            overload4.Display2();
         //Ex5
            Console.WriteLine("Ex5");
            var overload5 = new Ex5();
            overload5.Display();
         //Ex6
            Console.WriteLine("Ex6");
            ClassA a = new ClassA();
            a.Display1();
         //Ex7
            Console.WriteLine("Ex7");
            ClassC classC = new ClassE();
            ClassD classD = new ClassE();
            classC.XXX();
            classD.XXX();
        }
    }    
}
