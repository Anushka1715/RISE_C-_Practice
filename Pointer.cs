using System;

namespace Pointer
{
    internal class Pointer
    {
        static void Main(string[] args)
        {
 
     unsafe {
                int number = 10;
                int* pointer = &number; // Declare and initialize a pointer to 'number'

                Console.WriteLine("Value of number: " + number);
                Console.WriteLine("Address of number: " + (long)pointer);

                *pointer = 20; // Dereference the pointer and assign a new value

                Console.WriteLine("Value of number after modification: " + number);
            }
        }
    }
}
