using System;
using System.Data;

namespace PropertiesPractice
{
    public class PropertiesEx
    {
        public string name { get; set; }
        public int age { get; set; }
        public string contactDetails { get; set; }

        public static int x {  get; set; }

        //write only properties
        int Id = 0;
        public int ID { set { Id = 501; } }

        //readonly keyword variable
        readonly string collegeName = "Babaria Institue of Technology";

        //const in c#
        const int salary = 5000;

        //read only properties
        public string message
        {
            get { return "Hello" + name; }
        }

        public void showDetails()
        {
            Console.WriteLine("Name: {0} \n Age:{1} \n Contact Details: {2}",name,age,contactDetails);
            Console.WriteLine(message);
            Console.WriteLine("Read Only variable:"+collegeName);
            Console.WriteLine("Constant variable:"+salary);
            Console.WriteLine(x);
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            PropertiesEx p1 = new PropertiesEx();
            p1.name = "Aryan";
            p1.age = 25;
            p1.contactDetails = "8565945364";
        

            PropertiesEx.x = 5300;
            p1.showDetails();

            Console.ReadKey();
        }
    }
}
