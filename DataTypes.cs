using System;

namespace DataTypesAndOperators
{
    internal class Datatypes
    {
        static void Main(string[] args)
        {
            byte byteValue = 255;
            sbyte sbyteValue = -128;
            short shortValue = -32768;
            ushort ushortValue = 65535;
            int intValue = -2147483648;
            uint uintValue = 4294967295;
            long longValue = -9223372036854775808;
            ulong ulongValue = 18446744073709551615;

            // Floating-Point Types
            float floatValue = 3.40282347E+38F;
            double doubleValue = 1.7976931348623157E+308;
            decimal decimalValue = 79228162514264337593543950335M;

            // Character Type
            char charValue = 'D';

            // Boolean Type
            bool boolValue = true;

            // String Type
            string stringValue = "These are different datatypes used in c#!";

            // Displaying values

            Console.WriteLine("Byte Value: " + byteValue);
            Console.WriteLine("SByte Value: " + sbyteValue);
            Console.WriteLine("Short Value: " + shortValue);
            Console.WriteLine("UShort Value: " + ushortValue);
            Console.WriteLine("Int Value: " + intValue);
            Console.WriteLine("UInt Value: " + uintValue);
            Console.WriteLine("Long Value: " + longValue);
            Console.WriteLine("ULong Value: " + ulongValue);
            Console.WriteLine("Float Value: " + floatValue);
            Console.WriteLine("Double Value: " + doubleValue);
            Console.WriteLine("Decimal Value: " + decimalValue);
            Console.WriteLine("Char Value: " + charValue);
            Console.WriteLine("Boolean Value: " + boolValue);
            Console.WriteLine("String Value: " + stringValue);

            Console.ReadKey();
        }
    }
}
