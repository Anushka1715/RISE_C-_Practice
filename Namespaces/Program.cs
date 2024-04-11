using System;
using Namesapce2;
using MyNamespace;


namespace Namesapce2
{
    //we can have inter nal name spaces also 

    namespace interNamespace
    {
        public class InternalNamespaceClass
        {
            public void MethodOFInternalNAmespaceClass()
            {
                Console.WriteLine("I am the method of the internalNAmespace class");
            }
        }
    }
    public class Class1
    {
        public void Show()
        {
            Console.WriteLine("I am the class 1 method from the Namespace 2 name space");
        }

    }

    public class Class2
    {
        public void PrintMYName(string Name) { 
            Console.WriteLine("My Name is : {0}",Name);
        }
    }

    public class Class3 : MyNamespace.MyAbstractClass
    {
        public override void MyMessage()
        {
            Console.WriteLine("The implemented method of MyNAmespace in other projects name sapce.\n I cant use the internal member of this class here.");
        }
    }
}
namespace Namespaces
{
    public class Class1
    {
       public void PrintMessage()
        {
            Console.WriteLine("Hello I am method of class 1 from Namespaces namespace.");
        }
    }

    public class Class2
    {
        public void PrintNumbers() {
            Console.WriteLine("I am the class 2 method of Namespaces namespace an dprint 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Class1  class1 = new Class1();
            Class2 class2 = new Class2();
            class1.PrintMessage();
            class2.PrintNumbers();

            Console.WriteLine("We can access the methods of other name space also :");
            Namesapce2.Class1 class11 = new Namesapce2.Class1();
            class11.Show();

            Namesapce2.Class2 class12 = new Namesapce2.Class2();
            class12.PrintMYName("Anushka");

            Namesapce2.interNamespace.InternalNamespaceClass obj  = new Namesapce2.interNamespace.InternalNamespaceClass();
            obj.MethodOFInternalNAmespaceClass();

            MyNamespace.Class1 class13 = new MyNamespace.Class1();
            class13.Method1();

            Namesapce2.Class3 class14 = new Namesapce2.Class3();

            class14.MyMessage();

            Console.ReadKey();
        }
    }
}
