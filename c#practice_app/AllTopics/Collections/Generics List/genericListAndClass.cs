using System;
using System.Collections.Generic;

namespace Amol
{
    public class GenericListAndClass
    {

        public static void RunGenericListClassMethod()
        {

            GenericCustomer customer1 = new GenericCustomer()
            {
                ID = 101,
                Name = "Amol",
                Salary = 3000,
                Type = "Male"

            };
            GenericCustomer customer2 = new GenericCustomer()
            {
                ID = 102,
                Name = "Mangesh",
                Salary = 4000,
                Type = "Male"
            };
            GenericCustomer customer3 = new GenericCustomer()
            {
                ID = 103,
                Name = "Rajesh",
                Salary = 2300,
                Type = "Male"
            };
            GenericCustomer customer4 = new GenericCustomer()
            {
                ID = 104,
                Name = "Shila",
                Salary = 3440,
                Type = "Female"
            };
            GenericCustomer customer5 = new GenericCustomer()
            {
                ID = 105,
                Name = "Dipali",
                Salary = 7800,
                Type = "Female"
            };

            List<GenericCustomer> listCustomer = new List<GenericCustomer>();
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            listCustomer.Add(customer3);
            // New list for remaining customer

            List<GenericCustomer> listCustomerNew = new List<GenericCustomer>();
            listCustomerNew.Add(customer4);
            listCustomerNew.Add(customer5);

            // Suppose we want to add new list customer to first listCustomer then we should use AddRange() Method

            listCustomer.AddRange(listCustomerNew);          // IMPORTANT STATEMENT -- AddRange();

            foreach (GenericCustomer item in listCustomer)
            {
                Console.WriteLine("" + item.ID, item.Name, item.Salary); // That will print 5 records here.
            }

            // You can use GetRange(2,3) etc
            // statring index is 0 and (listCustomer.Count length) is how many elements we want to get.

            listCustomer.GetRange(0, listCustomer.Count);    // IMPORTANT STATEMENT -- GetRange();

            // This will allow multiple item to insert
            // Insert() will only allow to add only one object;

            listCustomer.InsertRange(0, listCustomerNew);     // IMPORTANT STATEMENT -- InsertRange();

            // This will allow to remove multiple item. -- RemoveRange(2,3)
            // Remove() allow to remove only oe item at a time
            // RemoveAt(4) will allow only one item to remove.
            // RemoveAll(x=>x.Type=="Male")  allow to remove all matching condition items.

            listCustomer.RemoveRange(0, listCustomer.Count);  // IMPORTANT STATEMENT -- RemoveRange();

        }

    }

    public class GenericCustomer
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
}
