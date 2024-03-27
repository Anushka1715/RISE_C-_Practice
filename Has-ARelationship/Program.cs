using System;

namespace Has_ARelationship
{
    public class Address
    {
        public string Addressline, City, State;
        public Address(string addLine, string city, string state) { 
            Addressline = addLine;
            City = city;
            State = state;
        }
    }

    class Employee
    {
        //when we dont want to inherit the class and still utilixe other class members we take
        //the object of that class in this class as the representative member
        //this establishes a has a relationship 
        //like here we can say every employee has a address

        public Address address;

        public int ID;
        public string Name;

        public Employee(int id, string name,Address addrs) {
        ID = id;
        Name = name;
        address = addrs;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID :{ID}");
            Console.WriteLine($"Employee Name :{Name}");
            Console.WriteLine($"AddressLine :{address.Addressline}");
            Console.WriteLine($"City :{address.City}");
            Console.WriteLine($"State :{address.State}");

        }
    }

    class details
    {
        public static void Main(string[] args)
        {
            Address a1 = new Address("Elite-Harmony", "Vadodara", "Gujarat");
            Employee e1 = new Employee(1001,"Arya",a1);

            e1.Display();

            Console.ReadKey();
        }
    }
}
