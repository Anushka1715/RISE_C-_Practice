using System;
using System.Runtime.InteropServices;

namespace properties
{
    internal class Program
    {
        public class A
           {
            static int f1 = 89;
           
            public static string name = "Aryan";

             static A()
            {
               int f2 = f1 + 90;
                Console.WriteLine("Static constructor was called: "+f2);
            }
            public static int x { get; set; }
            public static float y { get; set; }

            public static void show()
            {
                Console.WriteLine(x + " " + y);
                Console.WriteLine("Name:"+name);
            }
        }

        static class b {
            static int MyAmount = 5000;
            static string message = "hello";
                static b()//static constructors should be parameter less
            {
                Console.WriteLine(message);

                MyAmount = 800;
                Console.WriteLine("new amount:" + MyAmount);
            }

            public static void Mymethod(string name)
            {
                Console.WriteLine(message+" "+name);
            }
        }


        static void Main(string[] args)
        {
            //in normal class if we have static members we can't call the
            A a = new A();
            A.x = 10;
            A.y = 20;
            A.show();

            //cannot make objects of static class

            b.Mymethod("Riddhi");

            Console.ReadKey();
        }
    }
}
