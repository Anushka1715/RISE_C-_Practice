using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we can handle exceptions using try and catch blocks
            int[] arr = { 1, 2, 3, 4, 5 };
            try
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    //Console.WriteLine(arr[i]);
                    int result = arr[i] / 0; // this will lead to divde by zero arithmetic error;
                    Console.WriteLine(result);
                }

                Console.WriteLine(arr[7]); // this statement wil generate exception as we are trying to access an element out of the bound of the array

                Console.WriteLine("I will not run due to aexception.");


            } //we can use multiple catch blocks to handle more specific execptions and multiple exceptions that may occur.
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(ex.StackTrace);
            }
            catch (IndexOutOfRangeException ouex)
            {
                Console.WriteLine(ouex.Message);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(ouex.StackTrace);
            }
            catch (Exception e)//handles all type of exceptions
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(e.StackTrace);
            }
            finally // this will always execute no matter if exception occur or not , good practice to write resource release codes here.
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
