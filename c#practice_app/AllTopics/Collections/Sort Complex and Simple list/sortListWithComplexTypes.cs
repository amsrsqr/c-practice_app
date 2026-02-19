using System;
using System.Collections.Generic;


namespace Amol
{
    public class sortListWithComplexTypes
    {
        public static void RunSortComplexTypes()
        {
            ComplexCustomer customer1 = new ComplexCustomer()
            {
                Id = 1,
                Name = "Amol",
                Salary = 2000

            };
            ComplexCustomer customer2 = new ComplexCustomer()
            {
                Id = 2,
                Name = "Raju",
                Salary = 3000

            };
            ComplexCustomer customer3 = new ComplexCustomer()
            {
                Id = 3,
                Name = "Shanu",
                Salary = 1000

            };

            List<ComplexCustomer> listComplex = new List<ComplexCustomer>();
            listComplex.Add(customer1);
            listComplex.Add(customer2);
            listComplex.Add(customer3);

            Console.WriteLine("Before Sorting");
            foreach (var item in listComplex)
            {
                Console.WriteLine("Salary", item.Salary);
            }

            listComplex.Sort();
            listComplex.Reverse();

            Console.WriteLine("Before Sorting");
            foreach (var item in listComplex)
            {
                Console.WriteLine("Salary", item.Salary);
            }

            sortByName sn= new sortByName();  // We are creating instance of below class
            listComplex.Sort(sn);             // we are passing sn to sort the any value from the listComplex object

        }
    }

    // We can create our own sort class and we can resue that class for sorting in ascending order
    public class sortByName : IComparer<ComplexCustomer>
    {

        public int Compare(ComplexCustomer x, ComplexCustomer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class ComplexCustomer : IComparable<ComplexCustomer>  // If you want to sort then we should use this  "IComparable<ComplexCustomer>"  interface
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(ComplexCustomer other)
        {

            /*
            if (this.Salary > other.Salary)
            {
                return 1;
            }
            else if (this.Salary < other.Salary)
            {
                return -1;
            }
            else { 
                return 0;
            }
            */
            return this.Salary.CompareTo(other.Salary); // Instead of above code;

            //return this.Name.CompareTo(other.Name); // This will work for name sorting in ascending order

        }
    }
}
