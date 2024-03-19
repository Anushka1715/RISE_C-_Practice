using System;

namespace ArraysPractice
{
   public class A
    {
        int i;
        int j;

        //default constructor
        public A()
        {
            Console.WriteLine("Default COnstructor was called");
            i = 1;
            j = 1;
            Console.WriteLine(i + " " + j);
        }

        public A(int a, int b)
        {
            Console.WriteLine("Parameterized constructor was called");
            i = a;
            j = b;

            Console.WriteLine(i + " " + j);
        }
    }

  public class Test
    {
        public static void Main()
        {
            A a1 = new A();
            A a2 = new A(32,12);

            int[] array1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[,] array2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Single Dimensional Array: ");
            foreach(int i in array1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Multidimensional Array:");
           //for(int i =0;i< array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j <= array2.GetLength(1); j++)
            //    {
            //        Console.WriteLine(array2[i,j]);
            //    }
            //    Console.WriteLine(" ");
            //}

            for(int i= 0;i < 3; i++)
            {
                for(int j =0;j < 3; j++)
                {
                    Console.WriteLine("{0}", array2[i, j]);
                }
            }

            foreach(var i in array2)
            {
                Console.WriteLine(string.Join(",",i));
            }

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //taking input from user

            //int[,] array3 = new int[4, 3];
            //Console.WriteLine("Enter the numbers for multidimensional array:");
            //for(int i = 0; i < array3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array3.GetLength(1); j++)
            //    {
            //        array3[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < array3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array3.GetLength(1); j++)
            //    {
            //        Console.Write(array3[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //variable length argument
            Add(1,2,3);

            Add(4, 5, 10, 6, 8, 9);

        }

        public static void Add(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            { 
                result += numbers[i];
            }
            Console.WriteLine("The sum is:"+ result);
        }
    }
}
