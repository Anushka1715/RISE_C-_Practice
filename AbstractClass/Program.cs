using System;
using System.ComponentModel;

namespace AbstractClass
{
    //Abstract classes can have abstract and non abstract methods both
    //abstract methods do not contain implementation the classes have to inherit abstract class and provide implementation for
    //the abstract method
    //we cannot make objects of abstract classes
    //A class that inherits an abstract must provide implementation for all abstract methods in it

    public abstract class MyAbstractclass
    {
        public abstract void Show();

        public void Simplemethod()
        {
            Console.WriteLine("I am the simple method of absract class");
        }
    }

    public class Test : MyAbstractclass { 
    
        public override void Show()
        {
        Console.WriteLine("the implementation of Abstract class by  1st derived class.");
          }
        
    }

    public class test2 : MyAbstractclass
    {
        public override void Show()
        {
            Console.WriteLine("the implementation from 2nd implementing class");
        }
    }


    public class Program
    {
        public static void Main()
        {
            Test program = new Test();
            program.Show();
            program.Simplemethod();

            Test t1 = new Test();

            MyAbstractclass a1 = t1;
            t1.Show();  

            test2 t2 = new test2();
            MyAbstractclass a2 = t2;
            a2.Show();

            Console.ReadKey();
        }

    }
}
