using System;

namespace NullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int m = num1.GetValueOrDefault();
            //we cannot directly assign the values of nullable datatypes to simple datatypes
            Console.WriteLine("the value assigned to the int variable from a nullable type is:" + m);

            float? num2 = 28.3f;
            float nm2 = num2.GetValueOrDefault();
            Console.WriteLine("the value assigned to the int variable from a nullable type is:" + nm2);

            int? salary = 500;
            int salary2 = 500;
            Console.WriteLine(Nullable.Compare<int>(salary, salary2));//Compare method returns boolean value 

            if(Nullable.Compare(salary, salary2) < 0)
            {
                Console.WriteLine("salary<salary2");

            }
            else if(Nullable.Compare(salary, salary2) > 0)
            {
                Console.WriteLine("salary > salary2");

            }
            else if (Nullable.Compare(salary, salary2) == 0)
            {
                Console.WriteLine("salary=salary2");
            }

            //another way to assign vale of nullable data type to simple data type
            //null coalesing operator

            int? num3 = 36;
            int m3 = num3 ?? 56;
            Console.WriteLine("The null coalesing operator will check if num3 has some values or not if not will assign the value given" + m3);

             Console.ReadKey();
        }
    }
}
