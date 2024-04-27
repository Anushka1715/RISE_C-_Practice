using System;
using System.Collections.Generic;

namespace Delegates
{
    delegate bool IsPromotable(Employee emplist);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //here we haven't used delegate and so this is hard coded logic but some comapny can need to change the criteria for promotion logic other than this
        //so they will need to make modifications in the class Employee
        //instead we can use delegates as it provides us a lot of flexibility
        //using delegates we can pass method in the parameter
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                //if(employee.Experience >= 5)
                //{
                //    Console.WriteLine(employee.Name + " promoted");
                //}

                //replacing logic with delegate

                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }


    }
    internal class Program
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, Name = "Anushka", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Shreya", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 101, Name = "Rajeev", Salary = 5500, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "Rohan", Salary = 7000, Experience = 8 });
            empList.Add(new Employee() { ID = 101, Name = "Ashish", Salary = 5000, Experience = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList, isPromotable);

            Console.ReadKey();
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
