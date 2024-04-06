using System;

namespace Interface
{
    interface MyInterface
    {
         string Name { get; }//properties can be abstract and can be overriden
        void MethodOfInterface();
        void PrintMessage();
    }
     interface AnotherInterface
    {

        interface InternalInterface
        {
             void InternalInterfaceMethod();
        }
        void PrintNumbers();
    }

    class Implementer:MyInterface,AnotherInterface
    {
        //implementing classes have to give implementation for each members in the interface
       
        public  string Name { get { return "anushka"; } }
      
        public void PrintMessage()
        {
            Console.WriteLine("Hello {0}!!",Name);
        }
        public void MethodOfInterface() {
            Console.WriteLine("Hello I am the class implementing the interface.");
        }

        public void PrintNumbers()
        {
            for (int j = 0; j <10 ; j++)
            {
                Console.WriteLine(j);
            }
        }
    }

    class Implementer2:MyInterface,AnotherInterface.InternalInterface
    {

       public string Name { get { return "akshat"; } }
        void MyInterface.MethodOfInterface()
        {
            Console.WriteLine("I am the second implementor class");
        }
        public void PrintMessage()
        {
            Console.WriteLine("I am the print method implemented in the second implementer class.\n Hello "+Name);
        }

         void AnotherInterface.InternalInterface.InternalInterfaceMethod()
        {
            Console.WriteLine("I am the implemented method of internal class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //object of derived class will be made or we can take reference of interface and pass the derived class object
            Implementer i1 = new Implementer();
            i1.MethodOfInterface();
            i1.PrintMessage();

            Implementer2 implementer2 = new Implementer2();//tight coupling 

            implementer2.PrintMessage();
            i1.PrintNumbers();
            
            AnotherInterface.InternalInterface internalref = new Implementer2();
            internalref.InternalInterfaceMethod();

            MyInterface reference = new Implementer();//loose coupling
            reference.PrintMessage();
            MyInterface r = new Implementer2();
            r.MethodOfInterface();
            Console.ReadKey();
        }
    }
}
