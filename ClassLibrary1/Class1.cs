using System;

namespace ClassLibrary1
{
    public class Class1
    {
       public  void myMethod()
        {
            Console.WriteLine("I am the method of class library");
        }
    }

    public abstract class  Class2
    {
        public void myMethod()
        {
            Console.WriteLine("I am the method of the class library ka class 2");
        }

        abstract public void Display();
        
    }
}
