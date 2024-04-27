using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryMethodPractice
{

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Anushka",
                Salary = 50000
            };
            Customer customer1 = new Customer()
            {
                Id = 2,
                Name = "Shivam",
                Salary = 40000
            };
            Customer customer2 = new Customer()
            {
                Id = 3,
                Name = "milind",
                Salary = 50000
            };
            Customer customer3 = new Customer()
            {
                Id = 4,
                Name = "Aditya",
                Salary = 30000
            };
            Customer customer4 = new Customer()
            {
                Id = 5,
                Name = "Manish",
                Salary = 35000
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer.Id, customer);
            dictionaryCustomers.Add(customer1.Id, customer1);
            dictionaryCustomers.Add(customer2.Id, customer2);
            dictionaryCustomers.Add(customer3.Id, customer3);
            dictionaryCustomers.Add(customer4.Id, customer4);

            //retrieving the value from dictionary using the key
            Customer cust = dictionaryCustomers[3];

            Console.WriteLine("ID:{0}\nName:{1}\nSalary:{2}", cust.Id, cust.Name, cust.Salary);

            //printing the customers with its key so here our dictionary is a collectionof customerId and customers details
            foreach (KeyValuePair<int, Customer> kvpCustomer in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", kvpCustomer.Key);
                Customer c1 = kvpCustomer.Value;
                Console.WriteLine("Id:{0}\nName:{1}\nSalary:{2}", c1.Id, c1.Name, c1.Salary);
                Console.WriteLine("--------------------------------------------------------");
            }

            //getValue method to receive the value associated witha any of the parameter to the id present in dictionary
            Customer c101;
            if (dictionaryCustomers.TryGetValue(3, out c101))
            {
                Console.WriteLine("Id:{0}\nName:{1}\nSalary:{2}", c101.Id, c101.Name, c101.Salary);

            }
            else
            {
                Console.WriteLine("key not found.");
            }

            //count() used to get total no. of items in the dictionary
            Console.WriteLine("total items =" + dictionaryCustomers.Count);
            //LINQ extention methos of count method
            Console.WriteLine("total items =" + dictionaryCustomers.Count(KeyValuePair => KeyValuePair.Value.Salary > 40000));

            //remove() is used when you want to remove the item from dictionary
            //clear() will remove all keys and values in the dictionary.
            //dictionaryCustomers.Remove(customer1.Id);

            //covsrting array into dictionary

            Customer[] Customers = new Customer[3];
            Customers[0] = customer1;
            Customers[1] = customer2;
            Customers[2] = customer3;

            //ToDictionary method is uses to covert arrays into dictionary
            Dictionary<int, Customer> dictionary2 = Customers.ToDictionary(cust => cust.Id, cust => cust);
            foreach (KeyValuePair<int, Customer> kvp in dictionary2)
            {
                Console.WriteLine("key = {0}", kvp.Key);
                Customer c2 = kvp.Value;
                Console.WriteLine("Id:{0}\nName:{1}\nSalary:{2}", cust.Id, cust.Name, cust.Salary);
            }


            //Lists of customers
            List<Customer> Customer2 = new List<Customer>(2);
            //as list is of type customer we can add only customer object to the list
            Customer2.Add(customer1);
            Customer2.Add(customer2);
            Customer2.Add(customer3);//even though the intial size is 2 we can add more elements as unlike arrays lists can grow in size automatically

            //to retrive item from list
            //we use index
            Customer ListCustomer1 = Customer2[1];
            Console.WriteLine(" List Item: \n Id:{0},Name:{1},Salary={2}", ListCustomer1.Id, ListCustomer1.Name, ListCustomer1.Salary);

            //retrieving all the customers in List
            foreach (Customer c in Customer2)
            {
                Console.WriteLine(" All items:\n Id:{0},Name:{1},Salary={2}", c.Id, c.Name, c.Salary);

            }
            //to insert any new element in list at a specific index position we use Insert method
            Customer2.Insert(0, customer4);

            foreach (Customer c in Customer2)
            {
                Console.WriteLine(" All items:\n Id:{0}", c.Id);

            }

            //to retrieve index of a specific object from a list we use indexOf methods
            Console.WriteLine("The index of the customer4:" + Customer2.IndexOf(customer4));
            //two parameters in IndexOf method 1 is the object whose index we want,
            //2nd is the index from where we want to start searching the index
            Console.WriteLine();
            Customer2.Insert(3, customer4);
            Console.WriteLine("The index of the customer4:" + Customer2.IndexOf(customer4, 2));

            //we also have indexOf overloaded with 3 parameters
            //3rd is the add on into 2nd that will specify
            //the number of next elements till we want to search for
            Console.WriteLine("The index of the customer4:" + Customer2.IndexOf(customer4, 1, 3));//we get -1 if we are not able to find the element in the specified range

            //to check if the object exists in the list we use Contains method
            if (Customer2.Contains(customer1))
            {
                Console.WriteLine("the customer exists in the list");
            }
            else
            {
                Console.WriteLine("object doesnot exists in the list");
            }

            //exists method is also similar to contains but it checks the element exists or not based on some condtion
            //in exists method we need to pass predicate that is a lamda expression as condition
            if (Customer2.Exists(cust => cust.Name.StartsWith("o")))
            {
                Console.WriteLine("the customer exists in the list");
            }
            else
            {
                Console.WriteLine("object doesnot exists in the list");
            }

            //find() function searches for an element that matches the defined condition by the 
            //specified lamda expression and returns the first matching item from the list
            //unlike contains and exists which return boolean, find returns the actual object
            Customer C1 = Customer2.Find(cust => cust.Salary > 40000);
            Console.WriteLine("the customer with salary > 40000" + " " + C1.Name);

            //FindLast() works similar to that of find but returns the last matching item from the list
            Customer C2 = Customer2.FindLast(cust => cust.Salary < 20000);
            Console.WriteLine("the customer with salary < 50000" + " " + C1.Name);

            //FindAll returns all the items from the list that match the conditions specified by the lamda expressions
            //instead of single item it returns a list of items
            Customer2.Insert(1, customer1);
            Customer2.Insert(4, customer2);
            Customer2.Insert(5, customer2);
            Customer2.Insert(6, customer2);


            List<Customer> C3 = Customer2.FindAll(cust => cust.Name.Contains("M"));
            foreach (Customer c in C3)
            {
                Console.WriteLine(" All items:\n Id:{0}, Name:{1}", c.Id, c.Name);

            }

            //FindIndex() Function returns index of the first item that matches the condition 
            //specified by the lamda expression.
            int index = Customer2.FindIndex(cust => cust.Salary > 40000);
            Console.WriteLine("the index is:" + index);
            //overloaded FIndIndex with the starting index from where you want to  start looking for the index
            int index2 = Customer2.FindIndex(3, cust => cust.Salary > 30000);
            Console.WriteLine("the index is:" + index2);


            //FindlastIndex() returns the last matching items index
            int index3 = Customer2.FindLastIndex(cust => cust.Salary > 30000);
            Console.WriteLine("the index is:" + index3);

            //Array to list 
            Customer[] CustomerArray = new Customer[4];
            CustomerArray[0] = customer1;
            CustomerArray[1] = customer2;
            CustomerArray[2] = customer3;
            CustomerArray[3] = customer4;

            List<Customer> listFromArray = CustomerArray.ToList();
            foreach (Customer c in listFromArray)
            {
                Console.WriteLine(" List items:\n Id:{0}, Name:{1}", c.Id, c.Name);

            }

            //list to array
            Customer[] ArrayFromList = listFromArray.ToArray();
            foreach (Customer c in ArrayFromList)
            {
                Console.WriteLine(" Array items:\n Id:{0}, Name:{1}", c.Id, c.Name);

            }

            //list to Dictionary
            Dictionary<int, Customer> dict2 = listFromArray.ToDictionary(x => x.Id);
            foreach (KeyValuePair<int, Customer> kvp in dict2)
            {
                Console.WriteLine("Key = " + kvp.Key);
                Customer c = kvp.Value;
                Console.WriteLine(" Array items:\n Id:{0}, Name:{1}", c.Id, c.Name);

            }



            Console.ReadKey();
        }
    }

 
}
