using System;

namespace operatorsPractice
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            //aritmetic operators
            Console.WriteLine("Enter a number of your choice: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number of your choice: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");

            //relational operators
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"a != b: {a != b}");
            Console.WriteLine($"a > b: {a > b}");
            Console.WriteLine($"a < b: {a < b}");
            Console.WriteLine($"a >= b: {a >= b}");
            Console.WriteLine($"a <= b: {a <= b}");

            // Logical operators
            bool x = true, y = false;
            Console.WriteLine("\nLogical operators:");
            Console.WriteLine($"x && y: {x && y}");
            Console.WriteLine($"x || y: {x || y}");
            Console.WriteLine($"!x: {!x}");

            //conditional operator
            int result = (a > b) ? a : b;
            Console.WriteLine("\nConditional operator:");
            Console.WriteLine($"Result: {result}");

        }
    }
}
