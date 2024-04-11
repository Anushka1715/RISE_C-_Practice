using System;
using MyNamespace;

 namespace MyNamespace
{
    public class Class1 {
        static string name;
      
        public void Method1()
        {
            name = "sumit";
            Console.WriteLine("Hello I am Method 1 from MyNamespace");
        }
    }

    public abstract class MyAbstractClass {

        private string Subject = "Chemistry";

        protected int Salary = 1000;

        internal string Name = "Anushka";
        public abstract void MyMessage();


        protected void ProtectedMethod()
        {
            Console.WriteLine("The favourite subject of {0} is {1}",Name,Subject);
        }
    }
    
    
}

namespace NameSpacePractice
{
    class Test : MyNamespace.MyAbstractClass
    {
     
        public override void MyMessage()
        {
            Console.WriteLine("I am the implementation of abstract method of abstract class of the MYNameSpace");
            Console.WriteLine("The internal member is accesible here in the same assembly: "+Name);
            Console.WriteLine("I cant access the private member Subject in the derived class");
            Console.WriteLine("My Salary is {1} \n the protected method and variable is accessible in subclasses within same namespace",Salary);
        }


    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.MyMessage();

            MyNamespace.MyAbstractClass m1 = new Test();
            //m1.ProtectedMethod();
           // t1.ProtectedMethod();

            MyNamespace.Class1 myClass1 = new MyNamespace.Class1();
            myClass1.Method1();
             

            Console.ReadKey();
        }
    }
}
