using System;

namespace Indexers
{
    public class Students
    {
        private string[] names = new string[10];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }

    public class Program {
        //A C# indexer is a class property that allows you to access a member variable of a class or
        //struct using the features of an array.
        //In C#, indexers are created using this keyword.
        //Syntax:
        //<modifier> <return type> this [argument list]
        // {
        //    get
        //  {
        // your get block code
        //   }
        //  set
        // {
        // your set block code
        // }
        //  }
        //Parameterized property are called indexer.

      
        
        static void Main(string[] args)
        {
            Students s1 = new Students();
            s1[0] = "Anushka";
            s1[1] = "Rohan";
            s1[2] = "Rishi";
            s1[3] = "Arya";

            for(int i=0;i<4;i++)
            {
                Console.WriteLine(s1[i]);
            }

            Console.ReadKey();
        }
    }
}
