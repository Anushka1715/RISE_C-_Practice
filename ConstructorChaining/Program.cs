using System;


namespace ConstructorChaining
{
    //Calling a constructor from another constructor is called Constructor chaining.
    //If a constructor calls a current class constructor, then this keyword is used to identify the current class constructor.

    public class Employee
    {
        public int Id;
        public string Name;


        public Employee() : this(101, "Shreya")
        {
            Console.WriteLine("This is default constructor");
        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
           // Console.WriteLine("This constructor was called inside default constructor.");
            Console.WriteLine("EmployeeID:{0}\nEmployeeName:{1}",Id,Name);

        }

        //public static void Main(string[] args)
        //{
        //    Employee e = new Employee();
        //}
    }

    public class ProjectATeam : Employee
    {
        public ProjectATeam() : base(103, "Rajan")
        {
            Console.WriteLine("This is the default constructor of child class calling the base class cinstructor ");
        }

        static void Main(string[] args)
        {
            ProjectATeam e = new ProjectATeam();
        }
    }
}
