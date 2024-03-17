using System;

namespace Arrays
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 2, 9 };

            Array.Sort(numbers);
            Console.Write("Sorted Array: ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            Array.Reverse(numbers);
            Console.WriteLine("\nReversed array:");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            int index = Array.IndexOf(numbers, 8);
            Console.WriteLine("\nIndex of 8: " + index);

            Array.Resize(ref numbers, 10);
            numbers[5] = 7;
            numbers[6] = 8;
            numbers[7] = 9;
            numbers[8] = 10;
            Console.WriteLine("\nResized array:");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            string[] fruits = { "apple", "banana", "orange", "banana", "kiwi" };
            int lastIndex = Array.LastIndexOf(fruits, "banana");
            Console.WriteLine("\nLast index of banana: " + lastIndex);

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };
            Console.WriteLine("\nJagged array:");
            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(", ", item));
            }
        }
    }
}
