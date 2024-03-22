using System;
using System.Net.NetworkInformation;

namespace destructor
{
   //destructors are used to destruct instances of classes
   //
   public class MYClass
    {
        int i;
        int j;

        //constructor
        public MYClass() {
            i = 10;
            j = 20;
        }

        ~MYClass()
        {
            Console.WriteLine("Destructor was called");
        }

        public void show()
        {
            Console.WriteLine(i+" "+j);
        }
    }

    public class Test
    {
        public static void Main()
        {
            MYClass a1 = new MYClass();
            a1.show();
        }
    }
   
}
