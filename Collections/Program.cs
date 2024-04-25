using System;
using System.Collections;

namespace Collections
{
    //collections in c# are types designed to store, manage and manipulate similar data more efficiently.

    //.NET supports two types of collections 
    //1)generic collections 
    //2) non generic collections: can represent a value of different type.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList is the same as Array except that its size increases dynamically.An ArrayList can be used to add unknown data where you don't know the types and the size of the data.");

            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            foreach(var i in arlist1) { 
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

    }
}
