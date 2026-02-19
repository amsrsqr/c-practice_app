using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // AsReadOnly exist in this namespace
// TrueForAll()  -- Return true or false on whether if every element in the list matches to condition defined by specified condition
// AsReadOnly()  --  Return the read only wrapper for the current collection. use this method . If you don;t want client code to modify the collection
//  i.e add or remove any elements from the collection. the ReadOnlyCollection will not have methods to add or remove items from the collection
// TrimExcess()  -- Sets the capacity to the actual number of elements in the list. if that number is less than the threshold value.  


namespace Amol
{
    public class usefulMethodOfListCollectionClass
    {
        public static void RUnUsefulMethod()
        {

            usefulCustomer customer1 = new usefulCustomer()
            {
                Id = 1,
                Name = "Amol",
                Salary = 1000,
            };

            usefulCustomer customer2 = new usefulCustomer()
            {
                Id = 2,
                Name = "Javed",
                Salary = 3000,
            };

            usefulCustomer customer3 = new usefulCustomer()
            {
                Id = 3,
                Name = "Sajay",
                Salary = 4000,
            };

            List<usefulCustomer> myList = new List<usefulCustomer>(4);

            myList.Add(customer1);
            myList.Add(customer2);
            myList.Add(customer3);

            //1)
            Console.WriteLine("Salary greater then 500", myList.TrueForAll(x => x.Salary > 5000));   // return boolean true or false


            //2)
            ReadOnlyCollection<usefulCustomer> readOnlyCustomer = myList.AsReadOnly();  // that will give you read only acces from the collection
            Console.WriteLine("Salary greater then 500", readOnlyCustomer.Count());    // That will return the count of elements in that object

            //3)
            List<usefulCustomer> myNewList = new List<usefulCustomer>(100);
            myNewList.Add(customer1);
            myNewList.Add(customer2);
            myNewList.Add(customer3);
            Console.WriteLine("Capacity before trimming", myNewList.Capacity); // will be 100;

            myNewList.TrimExcess();   // that will set capacity of object depends on object exist in the list (Threshold value means how many object exist);

            Console.WriteLine("Capacity after trimming", myNewList.Capacity);  // will be 3


        }
    }

    public class usefulCustomer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}
