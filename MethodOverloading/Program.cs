using System;

namespace MethodOverloading
{
    public class Methodoverloading

    {
        static void Main(string[] args)
        {
            Console.WriteLine(add(12, 23));
            Console.WriteLine(add(12, 23, 25));
            Console.WriteLine(add(12.4f, 21.3f));
        }

        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static float add(float a, float b)
        {
            return a + b;
        }
    }
}
