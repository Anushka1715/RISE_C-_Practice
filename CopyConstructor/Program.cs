using System;

namespace CopyConstructor
{
    //The constructor which creates an object by copying variables from another object is called a copy constructor.
    //The purpose of a copy constructor is to initialize a new instance to the values of an existing instance.
    public class Employee
    {
        public int Id;
        public string Name;

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine("EmployeeID:{0}\nEmployeeName:{1}", Id, Name);

        }

        public Employee(Employee emp) {
            Id = emp.Id;
            Name = emp.Name;
        }

        public static void Main(string[] args)
        {
            Employee e = new Employee(102,"Kriti");
            Employee e2 = new Employee(e);
        }
    }
    }
