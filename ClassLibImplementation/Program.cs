using ClassLibrary1;
using System;
using System.Runtime.CompilerServices;

namespace ClassLibImplementation
{
    static class Extend
    {
        public static void show(this ClassLibrary1.Class1 obj)
        {
            Console.WriteLine("I am the extended stmt");
        }
    }

    class InheritedClass : ClassLibrary1.Class2
    {
        public override void Display()
        {
            Console.WriteLine("I am the method of the inherited class which oinhertis the class provided in the Class Library!!");
        }
    }
    internal class Program
    {
     
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 c1 = new ClassLibrary1.Class1();
            c1.myMethod();
            c1.show();

             InheritedClass c3 = new InheritedClass();  
            c3.myMethod();
            c3.Display();  
            
            Console.ReadKey();
        }
    }
}
