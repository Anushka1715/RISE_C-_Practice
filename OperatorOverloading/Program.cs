using System;
using System.Numerics;

namespace OperatorOverloading
{
    //The mechanism of giving a special meaning to a standard C# operator with respect to a user defined data type such as classes or structures is known as operator overloading.
    //it is not possible to overload all operators in C#.

    //following operators cant b overloaded
    //&&, ||, [] (Array index operator)
    //() (Conversion operator)
    //=, . , ?:, ->, new, is, as, sizeof

    //syntax: public static return_type operator op (argument list)
    public class OperatorOverloading
    {
        private int x;
        private int y; private int z;
        public OperatorOverloading()
        {

        }

        public OperatorOverloading(int i,int j)
        {
            x = i;
            y = j;
        }

        public void Show()
        {
            Console.WriteLine("{0} {1}", x, y);
        }

        public static OperatorOverloading operator -(OperatorOverloading c)
        {
            OperatorOverloading temp = new OperatorOverloading();
            temp.x = -c.x;
            temp.y= -c.y;
            return temp;
        }
    }


    public class Test
    {
        public static void Main()
        {
            OperatorOverloading c1 = new OperatorOverloading(10,60);
            c1.Show();
            OperatorOverloading c2 = new OperatorOverloading();
            c2 = -c1;
            c2.Show();

            Console.ReadKey();
        }
    }
}
