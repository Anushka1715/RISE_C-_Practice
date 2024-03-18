using System;

namespace ClassObject
{
    public class Student
    {
        int RollNo;
        string Name;
        string Department;

        public Student(int RollNo, string Name, string Department)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Department = Department;
        }
        public void Display()
        {
            Console.WriteLine("Student Name: {0} \n Roll No: {1} \n Department: {2}", this.Name, this.RollNo, this.Department);
        }
    }

    class StudentTest
    {
        public static void Main()
        {
            Student s1 = new Student(1, "Anushka", "CSE");
            s1.Display();

            Student s2 = new Student(2, "Sneha", "CSE");
            s2.Display();
            Console.ReadKey();
        }
    }


}
