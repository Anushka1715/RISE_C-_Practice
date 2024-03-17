using System;

namespace TypeCastingandTypeConversion
{
    internal class TypeCastingandTypeConversation
    {
        static void Main(string[] args)
        {
            double doubleNumber = 10.5;
            int intNumber = (int)doubleNumber;

            Console.WriteLine("number double {0} is converted to {1} integer.", doubleNumber, intNumber);

            string numberString = "123";
            int convertedNumber = Convert.ToInt32(numberString);

            Console.WriteLine("String {0} is converted to int {1}",numberString, convertedNumber);

            string parseNumberString = "456";
            int parsedNumber = int.Parse(parseNumberString);

            Console.WriteLine("String{0} is converted to int {1}", parseNumberString, parsedNumber);
        }
    }
}
