using System;

namespace enums
{
    public enum DaysOfWeek
    {
        //by default it gives 0,1 numeration to the members in enum
        //we can change it 
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }
    internal class Enums
    {
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Monday;
            Console.WriteLine("Today is: " + today);

            int dayValue = (int)DaysOfWeek.Friday;
            Console.WriteLine("Friday's value is: " + dayValue);
        }
    }
}
