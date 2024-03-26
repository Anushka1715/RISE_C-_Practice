using System;
using System.Data.SqlTypes;

namespace Practice_22_03_2024
{
    public class Student
    {
       public int Id { get; set; }
        public string Name { get; set; }

        int mark;
        public Student(int id, string name,int marks)
        {
            Id = id;
            Name = name;
            mark = marks;
        }
        public void StudentDetails()
        {
            Console.WriteLine("Student Id: {0} \n Student Name: {1} \n Marks:{2}",Id,Name,mark);
        }

        public void MarksUpdate(ref int mark)
        {
            mark = mark + 10;
            Console.WriteLine("the updated marks:" + mark);
        }

        public void ADD(int num1, int num2, out int result)
        {
            num1 = num1;
            num2 = num2;
            result = num1+ num2;
        }
        
    }

    class Test
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student(101, "Anushka", 35);
            s1.StudentDetails();
           s1.ADD(36, 94, out int res);
            Console.WriteLine("addition:"+res);
            s1.MarksUpdate(ref res);
        }
    }
}
