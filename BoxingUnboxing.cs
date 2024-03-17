using System;

namespace BoxingUnboxing
{
    internal class BoxingUnboxing
    {
        static void Main(string[] args)
        {
            //boxing means the transition from value type to the reference type(object type)
            int num = 55;

            object boxingOfnum = num;

            Console.WriteLine("original number: "+num);

            Console.WriteLine("boxed value: " + boxingOfnum);

            //unboxing means converting refernce type into value types
            //if dont typecast this we get error as it is current reference type
            int unboxingOfNum = (int)boxingOfnum;
            //or we can do
            int unboxingOfInt = Convert.ToInt32(boxingOfnum);

            Console.WriteLine("Unboxed value: "+unboxingOfInt);
        }
    }
}
