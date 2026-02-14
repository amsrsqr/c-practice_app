using System;
// what is equal method ?
// How can we override it ?
// equals, getHashCode, ToString methos comes from system.object import.

namespace Amol
{
    public class equalMethodAndOverride
    {
        public static void RunEqualMethodOverride()
        {

            // Using Normal value for comparison.
            int i = 10;
            int j = 20;

            Console.WriteLine(i == j);        // this gives reference equality
            Console.WriteLine(i.Equals(j));  // this gives value equality
//--------------------------------------------------------------------------------------------
            // Using Enum for comparison.

            Direction d1 = Direction.West;
            Direction d2 = Direction.East;

            Console.WriteLine(d1 == d2);
            Console.WriteLine(d1.Equals(d2));

//--------------------------------------------------------------------------------------------
            // Pointing to same object;
            // reference equality here
            // then value automatically same
            // so it become true.

            MyCustomer c1 = new MyCustomer();
            c1.firstName= "Test";
            c1.lastName= "Test";

            MyCustomer c2 = c1;
            Console.WriteLine(c1 == c2);       // true.
            Console.WriteLine(c1.Equals(c2));  // true
//--------------------------------------------------------------------------------------------
            // another case of object here
            // Here it become false that's why we override equals method.
            MyCustomer c3 = new MyCustomer();
            c3.firstName = "Test";
            c3.lastName = "Test";

            Console.WriteLine(c1 == c3);       // false.
            Console.WriteLine(c1.Equals(c3));  // false


        }
    }
    public enum Direction
    {
        East = 1,
        West = 2,
        South = 3,
        North = 4

    }

    public class MyCustomer
    {

        public string firstName { get; set; }
        public string lastName { get; set; }

        // Overriding Equals method here.
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;

            if(!(obj is MyCustomer)) return false;

            // if passed parameter object is system import So is not type of customer then we should typecast here.
            // Output will be  False and true 
            // == will be false and Equals will be true here.
            return this.firstName == ((MyCustomer)obj).firstName && this.lastName == ((MyCustomer)obj).lastName; 
        }

        public override int GetHashCode()
        {
          return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }

    }
}

