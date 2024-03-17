using System;

namespace VarAndDynamic
{
    internal class VarAndDynamic
    {
        static void Main(string[] args)
        {
            //var is used for implicit typing.
            //When you use var, the type of the variable is inferred by the compiler based on the value assigned to it at compile time.
            //However, once the type is inferred, it cannot be changed.
            var b = "Hello World";
            //now if we want to assign a number to b we cannot do that once its assigned a string it will only hold string values.
            Console.WriteLine(b);

            //dynamic is used for late binding.
            //When you use dynamic, type checking is deferred until runtime.
            //This means that you can assign any type of value to a dynamic variable,
            //and the compiler will not perform type checking until the code is actually executed.

            dynamic ICanHoldAnyDatatype = "How are you?";
            Console.WriteLine(ICanHoldAnyDatatype);

            ICanHoldAnyDatatype = 23;
            Console.WriteLine(ICanHoldAnyDatatype);

            ICanHoldAnyDatatype = new int[] {1,2,3,4,5}; 
            foreach (int i in ICanHoldAnyDatatype) { Console.WriteLine(i); };
        }
    }
}
