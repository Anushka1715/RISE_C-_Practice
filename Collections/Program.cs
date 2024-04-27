using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    //collections in c# are types designed to store, manage and manipulate similar data more efficiently.

    //.NET supports two types of collections 
    //1)generic collections:  work on the specific type specified in the program.
    //2) non generic collections: can represent a value of different type.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All the non generic collections available in c#:");
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

            Console.WriteLine("HashTable is similar to arraylist but represents the items as a combination of a key and value.");
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            //DictonaryEntry: a class whose object represents the data in a combination of key & value pairs.
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

            Console.WriteLine("\nStack");
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (var o in stk)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\nQueue");
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (object o in q)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\nAll the generic collections available in c#:");
            Console.WriteLine("\nList with specified type:");
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nDictionary generic collection:");
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            Console.WriteLine("\nStack generic collection:");
            Stack<string> stk1 = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nQueue generic collection:");
            Queue<string> q1 = new Queue<string>();

            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }

    }
}
