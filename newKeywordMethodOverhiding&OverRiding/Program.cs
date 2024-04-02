using System;

namespace newKeywordMethodOverhiding_OverRiding
{
    public class A
    {
        public virtual void show()
        {
            Console.WriteLine("Base class method is invoked");
        }
    }

    public class B : A
    {
        public override void show()
        {
            Console.WriteLine("The first Level derived class method invoked");
        }
    }

    public class C : B
    {
        public override void show()
        {
            Console.WriteLine("The 2nd Level derived class method invoked");
        }
    }

    public class Test
    {
        public static void Main(string[] args) { 
            A a = new A();
            B b= new B();
            C c= new C();

            //when we call methods from their own object's reference respectively the show method for respective class is called
            a.show();
            b.show();   
            c.show();


            Console.WriteLine("When we pass the derived class reference to base class object and we have used new key word in the derived class method:");
            A a1 = new A();
            a1 = new B();
            a1.show();

            A a2 = new A();
            a2 = new C();
            a2.show();


        Console.ReadKey();
        }
    }
}
