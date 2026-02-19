using System;
using System.ComponentModel;
// List is one of the generic collection classes present in System.Collections.Generic namespcae
// There are several generic collection classe
// 1. Dictionary
// 2. List
// 3. Stack
// 4. Queue etc

// A List class can be used to create a collection of any type.
// we can create a list of Integers, Strings and even complex types
// The objects stored in the list can be accessed by index
//  lists can grow in size automatically.
// This class also provides methods to search, sort, and manipulate lists.
namespace c_practice_app.AllTopics.Collections.Dictionary
{
    public class listCollectionClass
    {
        public static void RunListCollectionClass()
        {
            ListCustomer customer1 = new ListCustomer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            ListCustomer customer2 = new ListCustomer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            ListCustomer customer3 = new ListCustomer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            ListCustomer[] arrayCustomers = new ListCustomer[2];
            arrayCustomers[0] = customer1;
            arrayCustomers[1] = customer2;
            // The following line will throw an exception, Index was outside the bounds of the array. 
            // This is because, arrays does not grow in size automatically.

            // arrayCustomers[2] = customer3;

 //-------------------------------------------------------------------------------------------------------------

            // element the list size will automatically grow and we will not get an exception.

            List<ListCustomer> listCustomers = new List<ListCustomer>(2);
            // To add an element to the list, use Add() method.
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            // Adding an element beyond the initial capacity of the list will not throw an exception.
            listCustomers.Add(customer3);

 //-------------------------------------------------------------------------------------------------------------

            // Items can be retrieved from the list by index. The following code will 
            // retrieve the first item from the list. List index is ZERO based.

            ListCustomer cust = listCustomers[0];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
//-------------------------------------------------------------------------------------------------------------

            for (int i = 0; i < listCustomers.Count; i++)  // If we do i<=listCustomers.count then will get error outofboundexception because i will iterate 4 time.
            {
                ListCustomer customs = listCustomers[i];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customs.ID, customs.Name, customs.Salary);
            }
//---------------------------------------------------------------------------------------------------------------

            // Using foreach loop
            foreach (ListCustomer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
 //---------------------------------------------------------------------------------------------------------------

            // All generic collection classes including List are strongly typed. 
            // This means  if you have created a List of type Customer,  
            // only objects of type Customer can be added to the list. If you try to add an object of different type 
            // Then you would get a compiler error. The following line will raise a compiler error.
            // listCustomers.Add("This will not compile");
            // If you want to insert an item at a specific index location of the list, use Insert() method. 
            // The following line will insert customer3 object at index location 1.

            listCustomers.Insert(1, customer3);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", listCustomers[1].ID, listCustomers[1].Name, listCustomers[1].Salary);

            // To get the index of specific item in the list use Indexof() method
            // If we add any non exist element position of customer3 object then will get exception
            Console.WriteLine("Index of Customer3 object in the List = " + listCustomers.IndexOf(customer3, /*1 is start search index*/ 1, /*3 is on which position*/ 3));

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Here you can add new class object in existing ListCustomer class
            // Because SavingCUstomer is inheriting from ListCustomer class. As following
            SavingCustomer sc = new SavingCustomer();
            listCustomers.Add(sc);

 //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //There are several method of list collections classes which is as following
            // 1) Contains()
            // 2) Exists()
            // 3) Find()
            // 4) FindLast()
            // 5) FindAll()
            // 6) FindIndex()
            // 7) FindLastIndex()

/******************************************************************************/

            //1) This method returns true if the items exists, else false
            if (listCustomers.Contains(customer2))
            {
                Console.WriteLine("Customer2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Customer2 object does not exist in the list");
            }
 /***********************************************************************************/

            //2) This method returns true if the items exists, else false
            if (listCustomers.Exists(x => x.Name.StartsWith("M")))
            {
                Console.WriteLine("List contains customer whose name starts with M");
            }
            else
            {
                Console.WriteLine("List does not contain a customer whose name starts with M");

            }
/*************************************************************************************/

            //3) Find() method searches for an element that matches the conditions defined by the specified lambda expression and returns the first matching item from the list

            ListCustomer customer = listCustomers.Find(customer => customer.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);


/***************************************************************************************/

            // 4) FindLast() method searches for an element that matches the conditions defined by the specified lambda expression and returns the Last matching item from the list

            ListCustomer customerMatch = listCustomers.FindLast(customer => customer.Salary > 5000);

 /****************************************************************************************/

            //5) FindAll() method returns all the items from the list that  match the conditions specified by the lambda expression

            List<ListCustomer> filteredCustomers = listCustomers.FindAll(customer => customer.Salary > 5000);
            foreach (ListCustomer cstmr in filteredCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cstmr.ID, cstmr.Name, cstmr.Salary);

            }
/**************************************************************/

            // 6) FindIndex() method returns the index of the first item, that matches the 
            // condition specified by the lambda expression. There are 2 other overloads
            // of this method which allows us to specify the range of elements to 
            // search, with in the list.

            int index = listCustomers.FindIndex(1, 3, customer => customer.Salary > 5000);


/***********************************************************************/

            //6) FindLastIndex() method returns the index of the last item,
            // that matches the condition specified by the lambda expression. 
            // There are 2 other overloads of this method which allows us to specify 
            // the range of elements to search, with in the list.

            int lastIndex = listCustomers.FindLastIndex(customer => customer.Salary > 5000);

 /*************************************************************************/

            //Convert Array to List

            List<ListCustomer> listCustomerArr= arrayCustomers.ToList(); // This is the statement
            foreach (var item in listCustomerArr)
            {
                Console.WriteLine(item.Name, item.Salary);
            }

/***************************************************************************/

            //Convert List to Array
            List<ListCustomer> listArray = new List<ListCustomer>();
            listArray.Add(customer1);
            listArray.Add(customer2);

            ListCustomer[] myArray = listArray.ToArray();   // This is the statement.

            foreach (var item in myArray)
            {
                Console.WriteLine(item.Name, item.Salary);
            }
/**************************************************************/
            // Convert List to Dictionary

            List<ListCustomer> listDictionary = new List<ListCustomer>();

            Dictionary<int , ListCustomer> myDict= listDictionary.ToDictionary(x => x.ID);  // This is the statement.

            foreach (KeyValuePair<int, ListCustomer> item in myDict)
            {
                ListCustomer values= item.Value;  // This is used to extract the values from item.value
                Console.WriteLine("Key= {0} && Value= {1}", item.Key, values.ID, values.Name, values.Salary);
            }


            /****END*****/
        }

        public class ListCustomer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }

        public class SavingCustomer : ListCustomer { }  // IMPORTANT statement.

    }
}
