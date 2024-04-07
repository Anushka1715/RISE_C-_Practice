using System;

namespace Structs
{
    //Structs are value type and lightweight alternative to a class.
    //it is simply a composite data type consisting of a number of elements of other types.
    //Similar to classes, structures have behaviors and attributes.
    //As a value type, structures directly contain their value so their object or instance is stored on the stack.
    //C# Structs support access modifiers, constructors, indexers, methods, fields, nested types, operators, and properties. 

    public struct Student
    {
        int Id;
        string Name;
        public string favouriteSubject { get; set; }

        public Student(int Id, string Name,string sub)
        {
            this.Id = Id; this.Name = Name;this.favouriteSubject = sub;
        }

        public void DisplayStudent()
        {
            Console.WriteLine("Id:{0}\nName:{1}\nFavourite Subject:{2}",Id,Name,favouriteSubject);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student(1,"Anurag","Chemistry");
            student.DisplayStudent();
        }
    }
}
