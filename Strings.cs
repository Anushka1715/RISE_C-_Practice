using System;
using System.Text;

namespace strings
{
    internal class Strings
    {
        static void Main(string[] args)
        {
            // String operations
            string str = "Hello, World!";
            Console.WriteLine("Original string: " + str);

            // Length property
            Console.WriteLine("Length: " + str.Length);

            // Substring method
            string substring = str.Substring(7);
            Console.WriteLine("Substring from index 7: " + substring);

            // IndexOf method
            int index = str.IndexOf("World");
            Console.WriteLine("Index of 'World': " + index);

            // Replace method
            string replacedStr = str.Replace("World", "Universe");
            Console.WriteLine("Replaced string: " + replacedStr);

            // ToUpper method
            string upperCaseStr = str.ToUpper();
            Console.WriteLine("Uppercase string: " + upperCaseStr);

            // StringBuilder operations
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(", ");
            sb.Append("StringBuilder");
            sb.AppendLine("!");

            Console.WriteLine("\nStringBuilder:");
            Console.WriteLine(sb.ToString());

            // AppendFormat method
            sb.AppendFormat("The length of the string is {0}.", sb.Length);
            Console.WriteLine("\nAfter AppendFormat:");
            Console.WriteLine(sb.ToString());
        }
    }
}
