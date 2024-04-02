using System;

namespace BaseKeyWord
{
    //base keyword is used to access members of the base class from within a derived class.
    //base class access is permitted only in a constructor,an instance method,or an instance property accessor
    //it is an error to use the base keyword from within a static method

    public class Person
    {
        public string Name;
        public string DateOfBirth;

        public Person(){
            }
        public Person(string name, string dateOfBirth)
        {
            Console.WriteLine("base constructor invoked");
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public void Show()
        {
            Console.WriteLine("Name:{0}\nDateOfBirth{1}",Name,DateOfBirth);
        }
    }

    class Employee : Person
    {
        public int Id;
        public string Department;
        public int Salary;

        public Employee() { }
        public Employee(int Id,string Name,string DateOfBirth, string Department, int Salary) :base(Name, DateOfBirth)
        {
            this.Id= Id;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Department= Department;
            this.Salary = Salary;
        }

        public void Show()
        {
            Console.WriteLine("Derived Class Constructor called\nThe Employee Details:");
            Console.WriteLine("Id:{0}\nName{1}\nDateOfBirth:{2}\nDepartment:{3}\nSalary:{4}",Id,Name,DateOfBirth,Department,Salary);
        }

    }

    class test
    {
        public static void Main()
        {
            Employee e = new Employee(101,"Anushka","17-12-2001",".Net",50000);
            Person person;

            person = e;

            person.Show();

            e.Show();

            Console.ReadKey();

        }
    }
}
