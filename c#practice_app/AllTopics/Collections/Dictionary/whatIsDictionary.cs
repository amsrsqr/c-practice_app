using System;
using System.Collections.Generic; // Dictionary exist in this namespace
using System.Linq; // For count methods

// 1. A dictionary is a collection of(key, value) pairs.
// 2. Dictionary class is present in "System.Collections.Generic namespace".
// 3. When creating a dictionary, we need to specify the type for key and value.
// 4. Dictionary provides fast lookups for values using keys.
// 5. Keys in the dictionary must be unique.

namespace c_practice_app.AllTopics.Collections.Dictionary
{
    public class whatIsDictionary
    {
        public static void RunBasicDictionary()
        {
            // Create a Dictionary, CustomerID is the key. -- Type is int
            // Customer object is the value.    -- Type is Customer
            // int is key and CustomerDictionary is value in below statement
            // You can do like that as well -- Dictionary<int, string> dictionaryCustomers = new Dictionary<int, string>();
            Dictionary<int, CustomerDictionary> dictionaryCustomers = new Dictionary<int, CustomerDictionary>();

           
            // Create Customer Objects
            CustomerDictionary customr1 = new CustomerDictionary()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            CustomerDictionary customr2 = new CustomerDictionary()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            CustomerDictionary customr3 = new CustomerDictionary()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };


            // Add CustomerDictionary objects to the dictionary
            dictionaryCustomers.Add(customr1.ID, customr1);
            dictionaryCustomers.Add(customr2.ID, customr2);
            dictionaryCustomers.Add(customr3.ID, customr3);

//----------------------------------------------------------------------------------------------------------------------------------
            // Retrieve the value (CustomerDictionary object) from the dictionary,
            // using key (customer ID). The fastest way to get a value
            // from the dictionary is by using its key
            Console.WriteLine("Customer 101 in customer dictionary");
            CustomerDictionary customer101 = dictionaryCustomers[101];
            Console.Write(customer101.ID + " " + customer101.Name +" "+ customer101.Salary);

//----------------------------------------------------------------------------------------------------------------------------------



            // It is also possible to loop thru each key/value pair in a dictionary
            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (KeyValuePair<int, CustomerDictionary> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                CustomerDictionary cust = customerKeyValuePair.Value; // due to value is CustomerDictionary object so
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
//----------------------------------------------------------------------------------------------------------------------------------

            // You can also use implicitly typed variable VAR to 
            // loop thru each key/value pair in a dictionary. But try
            // to avoid using var, as this makes your code less readable
            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (var customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                CustomerDictionary cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }

 //----------------------------------------------------------------------------------------------------------------------------------

            // To get all the keys in the dictionary
            Console.WriteLine("All Keys in Customer Dictionary");
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }

//----------------------------------------------------------------------------------------------------------------------------------

            // To get all the values in the dictionary
            Console.WriteLine("All Customer objects in Customer Dictionary");
            foreach (CustomerDictionary customer in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }

            // If you try to add a key that already exists in the dictionary you 
            // will get an exception - An item with same key has already been 
            // added. So, check if the key already exists

            if (!dictionaryCustomers.ContainsKey(101))
            {
                dictionaryCustomers.Add(101, customr1);
            }

            // When accessing a dictionary value by key, make sure the dictionary 
            // contains the key, otherwise you will get KeyNotFound exception at runtimes.

            if (dictionaryCustomers.ContainsKey(110))
            {
                CustomerDictionary cus = dictionaryCustomers[110];
            }
            else
            {
                Console.WriteLine("Key does not exist in the dictionary");
            }

            //--------------------------------------------------------------------------------------------------------------------------------------

            // If you are not sure if a key is present or not, you can use 
            // TryGetValue() method to get the value from a dictionary instead of this -- dictionaryCustomers[110];.

            CustomerDictionary customer999;
            if (dictionaryCustomers.TryGetValue(999, out customer999))  // will return Boolean value
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer999.ID, customer999.Name, customer999.Salary);
            }
            else
            {
                Console.WriteLine("Customer with Key = 999 is not found in the dictionary");
                Console.WriteLine("-------------------------------------------------------------------");
            }

//----------------------------------------------------------------------------------------------------------------------------------------

            // To find the total number of items in a dictionary use Count() method
            Console.WriteLine("Total items in Dictionary = {0}", dictionaryCustomers.Count());


//----------------------------------------------------------------------------------------------------------------------------------------

            // LINQ extension methods can be used with Dictionary. For example, to find the 
            // total employees whose salary is greater than 5000.
            Console.WriteLine("Items in dictionary where Salary is greater than 5000 = {0}",
                dictionaryCustomers.Count(x => x.Value.Salary > 5000));  // will return only count which has salary is greater than 5000;

//----------------------------------------------------------------------------------------------------------------------------------------
            // To remove an item from the dictionary, use Remove() method
            dictionaryCustomers.Remove(101);
            dictionaryCustomers.Remove(99);// If we not exist id pass then it will not return any error

            //----------------------------------------------------------------------------------------------------------------------------------------

            // To remove all items from the dictionary, use Clear() method
            dictionaryCustomers.Clear();

//----------------------------------------------------------------------------------------------------------------------------------------

            // Create an array of customers using list or using array
            List<CustomerDictionary> listCustomers= new List<CustomerDictionary>();
            listCustomers.Add(customr1);
            listCustomers.Add(customr2);
            listCustomers.Add(customr3);

            //OR
            CustomerDictionary[] arrayCustomers = new CustomerDictionary[3];
            arrayCustomers[0] = customr1;
            arrayCustomers[1] = customr2;
            arrayCustomers[2] = customr3;

            // Convert customer array to a dictionary using ToDictionary() method.
            // In this example, key is Customer ID and value is the customer object

            Dictionary<int, CustomerDictionary> dict = arrayCustomers.ToDictionary(customer => customer.ID, customer => customer);

            // OR        
            Dictionary<int, CustomerDictionary> dict1 = arrayCustomers.ToDictionary(customer => customer.ID);

            // OR use a foreach loop
            Dictionary<int, CustomerDictionary> dict2 = new Dictionary<int, CustomerDictionary>();
            foreach (CustomerDictionary cust in arrayCustomers)
            {
                dict.Add(cust.ID, cust);
            }
//----------------------------------------------------------------------------------------------------------------------------------------
        }

    }

    public class CustomerDictionary
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
