using System;

namespace PartialClass
{
    public partial class MyClass
    {
        string name;
        int age;

       public  MyClass(string name,int age) { 
            this.name = name;
            this.age = age;
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass m1 = new MyClass("Anushka",22);
            m1.Show();
            Console.ReadKey();
        }
    }


    partial class MyClass
    {
        public void Show()
        {
            Console.WriteLine("Name:" + name + " Age:" + age);
        }
    }
}
