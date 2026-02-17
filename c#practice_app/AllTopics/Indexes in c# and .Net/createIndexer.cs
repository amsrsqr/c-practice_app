using System;
// Used "this" keyword to create indexer
// Just like propeties have get and set accessor
// Indexers can be overloaded


namespace Amol
{
    public class CustomerIndexer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class ShopIndexer
    {
        private List<CustomerIndexer> listCustomers;

        public ShopIndexer()
        {
            listCustomers = new List<CustomerIndexer>();

            listCustomers.Add(new CustomerIndexer
            { CustomerID = 1, Name = "Mike", Gender = "Male" });
            listCustomers.Add(new CustomerIndexer
            { CustomerID = 2, Name = "Pam", Gender = "Female" });
            listCustomers.Add(new CustomerIndexer
            { CustomerID = 3, Name = "John", Gender = "Male" });
            listCustomers.Add(new CustomerIndexer
            { CustomerID = 4, Name = "Maxine", Gender = "Female" });
            listCustomers.Add(new CustomerIndexer
            { CustomerID = 5, Name = "Emiliy", Gender = "Female" });
            listCustomers.Add(new CustomerIndexer
            { CustomerID = 6, Name = "Scott", Gender = "Male" });
            listCustomers.Add(new CustomerIndexer
            { CustomerID = 7, Name = "Todd", Gender = "Male" });
            listCustomers.Add(new CustomerIndexer
            { CustomerID = 8, Name = "Ben", Gender = "Male" });
        }

        public string this[int customerID]
        {
            // Just like properties indexers have get and set accessors
            get
            {
                return listCustomers.
                    FirstOrDefault(x => x.CustomerID == customerID).Name;
            }
            set
            {
                listCustomers.
                    FirstOrDefault(x => x.CustomerID == customerID).Name = value;
            }
        }

        // We can create instance of this ShopIndexer class and pass a value to above method like this
        /*
         
             ShopIndexer shop= new ShopIndexer();
             Console.WriteLine(shop[2]);  // which will return the record of 2nd index from the list.
             shop[3]

           // To set name of the customer using indexer

              shop[3]="Name changed here"  // for this 3 index.

         */
    }
}
