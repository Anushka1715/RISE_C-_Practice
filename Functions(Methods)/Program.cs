using System;

namespace Functions_Methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 17;

            Console.WriteLine("The value of a before a function call: {0}", a);

            //call by value
            Increment(a);

            Console.WriteLine("The value of a after function:" + a);

            //call by reference
            //int call by reference the values are manipulated at its original location as we are passing reference of the varible using
            //ref keyword.

            Console.WriteLine("The value of b before a function call: {0}", b);
            Increment(ref b);
            Console.WriteLine("The value of b after function:" + b);

            //the out keyword is used to get the values from function and display it outside it
            Calculate(a, b, out int Sum, out int Product, out int Remainder);
            Console.WriteLine("sum:{0},Product:{1},Remainder:{2}", Sum, Product, Remainder);

            //variable length of arguments
            Show("Raman", "Ramesh", 101, 20);
            Show("Raman", "Ramesh", "Riya", 900 ,102, 23);

        }

        static void Increment(int a)
        {
            a++;
            Console.WriteLine("This is call by value so original value at a's location is unchanged instead a copy of a was used:" + a);
        }

        //this is the call by reference method so ref keyword will be used at the time of methd defination and calling
        static void Increment(ref int a)
        {
            a++;
            Console.WriteLine("This is call by reference so original value at b's location is changed with this incremented value:" + a);
        }

        public static void Calculate(int Num1, int Num2, out int Sum, out int Product, out int Remainder)
        {
            Sum = Num1 + Num2;
            Product = Num1 * Num2;
            Remainder = Num1 % Num2;
        }

        //params keyword can be used to represent a variable length argument,
        //which allows a function to accept a variable number of parameters.
        public static void Show(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
