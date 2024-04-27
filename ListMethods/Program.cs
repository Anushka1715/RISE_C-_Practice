using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListMethods
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }

    public class ListMethodsPractice
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "A",
                Salary = 10000,
                Type = "RetailCustomer"
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "B",
                Salary = 20000,
                Type = "RetailCustomer"
            };
            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "C",
                Salary = 10000,
                Type = "RetailCustomer"
            };
            Customer customer4 = new Customer()
            {
                Id = 4,
                Name = "D",
                Salary = 25000,
                Type = "CorporateCustomer"
            };
            Customer customer5 = new Customer()
            {
                Id = 5,
                Name = "E",
                Salary = 20000,
                Type = "CorporateCustomer"
            };

            List<Customer> RetailCustomerList = new List<Customer>();
            RetailCustomerList.Add(customer1);
            RetailCustomerList.Add(customer2);
            RetailCustomerList.Add(customer3);

            List<Customer> CorporateCustomerList = new List<Customer>();
            CorporateCustomerList.Add(customer4);
            CorporateCustomerList.Add(customer5);

            //AddRange function allows us to add another list of items to the end of the list.
            RetailCustomerList.AddRange(CorporateCustomerList);

            foreach (Customer customer in RetailCustomerList)
            {
                Console.WriteLine("ID = {0}\nName={1}\nSalary={2}\nType={3}", customer.Id, customer.Name, customer.Salary, customer.Type);
                Console.WriteLine("-----------------------------------------------------------");
            }

            //GetRange gives the list of items in the range we want to get items from
            //first parameter the index to start from and then the number of elements you want
            List<Customer> l1 = RetailCustomerList.GetRange(0, 2);

            Console.WriteLine("The items returned from get range:");

            foreach (Customer customer in l1)
            {
                Console.WriteLine("ID = {0}\nName={1}\nSalary={2}\nType={3}", customer.Id, customer.Name, customer.Salary, customer.Type);
                Console.WriteLine("-----------------------------------------------------------");
            }

            //InsertRange allows to insert another list of items to your list at the specified index
            Customer customer6 = new Customer()
            {
                Id = 6,
                Name = "J",
                Salary = 30000,
                Type = "RetailCustomer"
            };
            Customer customer7 = new Customer()
            {
                Id = 7,
                Name = "K",
                Salary = 15000,
                Type = "RetailCustomer"
            };
            Customer customer8 = new Customer()
            {
                Id = 8,
                Name = "L",
                Salary = 25000,
                Type = "CorporateCustomer"
            };
            List<Customer> newl2 = new List<Customer>();
            newl2.Add(customer6);
            newl2.Add(customer7);
            newl2.Add(customer8);
            newl2.Add(customer4);
            newl2.Add(customer5);

            RetailCustomerList.InsertRange(2, newl2);
            Console.WriteLine("the inserted range of items:");
            foreach (Customer customer in RetailCustomerList)
            {
                Console.WriteLine("ID = {0}\nName={1}\nSalary={2}\nType={3}", customer.Id, customer.Name, customer.Salary, customer.Type);
                Console.WriteLine("-----------------------------------------------------------");
            }

            //Remove,RemoveAt,RemoveAll
            //RemoveRange() method removes a range of elements from the list
            //expects 2 parameters start index in the list and the number of elements to remove
            //if we want to remove all elements from the ist without specifying any condition,then use Clear() function

            RetailCustomerList.RemoveRange(2, 2);
            Console.WriteLine("The list after removing items:");
            foreach (Customer customer in RetailCustomerList)
            {
                Console.WriteLine("ID = {0}\nName={1}\nSalary={2}\nType={3}", customer.Id, customer.Name, customer.Salary, customer.Type);
                Console.WriteLine("-----------------------------------------------------------");
            }
            //Remove is used to remove the first occurrence of a specific object from the list.
            List<Customer> newl3 = new List<Customer>();
            newl3.Add(customer6);
            newl3.Add(customer7);
            newl3.Add(customer8);
            newl3.Add(customer4);
            newl3.Add(customer5);
            newl3.Add(customer3);

            newl3.Remove(customer6);//parameter in Remove is the direct object item
            Console.WriteLine("Remove method:");
            foreach (Customer customer in newl3)
            {
                Console.WriteLine("ID = {0}\nName={1}\nSalary={2}\nType={3}", customer.Id, customer.Name, customer.Salary, customer.Type);
                Console.WriteLine("-----------------------------------------------------------");
            }

            //RemoveAll(Predicate<T> match) removes all the elements that match the conditions specified by lamda expressions
            newl3.RemoveAll(cust => cust.Salary > 20000);
            Console.WriteLine("RemoveAll method:");
            foreach (Customer customer in newl3)
            {
                Console.WriteLine("ID = {0}\nName={1}\nSalary={2}\nType={3}", customer.Id, customer.Name, customer.Salary, customer.Type);
                Console.WriteLine("-----------------------------------------------------------");
            }

            //RemoveAt(int index) is used to remove the element at the specified index
            newl3.RemoveAt(1);
            Console.WriteLine("RemoveAt method:");
            foreach (Customer customer in newl3)
            {
                Console.WriteLine("ID = {0}\nName={1}\nSalary={2}\nType={3}", customer.Id, customer.Name, customer.Salary, customer.Type);
                Console.WriteLine("-----------------------------------------------------------");
            }


            Customer customer11 = new Customer()
            {
                Id = 1,
                Name = "A",
                Salary = 18000,

            };
            Customer customer12 = new Customer()
            {
                Id = 2,
                Name = "B",
                Salary = 26000,

            };
            Customer customer13 = new Customer()
            {
                Id = 3,
                Name = "C",
                Salary = 15000,
            };
            Customer customer14 = new Customer()
            {
                Id = 4,
                Name = "D",
                Salary = 25000,

            };
            Customer customer15 = new Customer()
            {
                Id = 5,
                Name = "E",
                Salary = 27000,

            };



            List<Customer> ComplexTypeList = new List<Customer>(100);
            ComplexTypeList.Add(customer14);
            ComplexTypeList.Add(customer12);
            ComplexTypeList.Add(customer15);
            ComplexTypeList.Add(customer11);
            ComplexTypeList.Add(customer13);

            //TrueForAll method returns boolean true or false when the condition i.e the predicate is is fulfilled for
            //each item in the list

            Console.WriteLine("Are all salries greater than 19000 = " +
                ComplexTypeList.TrueForAll(x => x.Salary > 19000));

            Console.WriteLine("Are all salries greater than 10000 = " +
            ComplexTypeList.TrueForAll(x => x.Salary > 10000));

            //AsReadOnly is used to make our list unchangable when we want our list collection to be 
            //safe and no one can change add or remove its items we use this method
            //this returns a read only collection
            ReadOnlyCollection<Customer> readOnlyCustomers = ComplexTypeList.AsReadOnly();
            //doing this we cant change add or remove any elements we can just retrieve the elements of the list
            //we can taek counts or perform operations like sum using the values or items but no manipulation on the list items
            Console.WriteLine("Number of items present in list:" + readOnlyCustomers.Count);

            //list.Capacity gives the limit that the items we can add in the list as here we have given 100
            //TrimExcess is  methos that trims the extra space if we are not utilizing the complete capacity of the list
            //this method is used to minimize the overhead of a collections memory

            Console.WriteLine("Capacity of the list before Trimming:" + ComplexTypeList.Capacity);
            ComplexTypeList.TrimExcess();
            Console.WriteLine("Capacity of the list after Trimming:" + ComplexTypeList.Capacity);

            Console.ReadKey();
        }
    }
}
