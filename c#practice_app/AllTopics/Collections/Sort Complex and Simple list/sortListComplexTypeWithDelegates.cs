using System;
using System.Collections.Generic;

namespace Amol
{
    public class sortListComplexTypeWithDelegates
    {
        public static void RunComplexTypeDelegates()
        {
            ComplexDelegatesCustomer customer1 = new ComplexDelegatesCustomer()
            {
                Id = 1,
                Name = "Amol",
                Salary = 2000

            };
            ComplexDelegatesCustomer customer2 = new ComplexDelegatesCustomer()
            {
                Id = 2,
                Name = "Raju",
                Salary = 3000

            };
            ComplexDelegatesCustomer customer3 = new ComplexDelegatesCustomer()
            {
                Id = 3,
                Name = "Shanu",
                Salary = 1000

            };

            List<ComplexDelegatesCustomer> listComplex = new List<ComplexDelegatesCustomer>();
            listComplex.Add(customer1);
            listComplex.Add(customer2);
            listComplex.Add(customer3);

            // Using delegates to sort a list by id.
            // we have created delegates comparision function

            Comparison<ComplexDelegatesCustomer> customerCompare = new Comparison<ComplexDelegatesCustomer>(Comparison);

            Console.WriteLine("Before Sorting");

            foreach (var item in listComplex)
            {
                Console.WriteLine("Salary", item.Salary);
            }

            listComplex.Sort(customerCompare);  // we are passing instance to sort method.

            Console.WriteLine("after Sorting");

            foreach (var item in listComplex)
            {
                Console.WriteLine("Salary", item.Salary);
            }

            // We can use delegates directly like this to sort the list.   // IMPORTANT

            listComplex.Sort(delegate (ComplexDelegatesCustomer x, ComplexDelegatesCustomer y)
            {
                return x.Id.CompareTo(y.Id);
            });

            // We can use lambda expression to do the same as below

            listComplex.Sort((x,y)=> x.Id.CompareTo(y.Id));


        }

        // Here we have created our own sort method for this class.
        private static int Comparison(ComplexDelegatesCustomer x, ComplexDelegatesCustomer y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }

    public class ComplexDelegatesCustomer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }

}
