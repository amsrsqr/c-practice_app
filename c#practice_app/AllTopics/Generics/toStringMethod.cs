using System;
// What is toString() method ?
// we shy we override it ?
// understand below example is best for you.

namespace Amol
{
    public class toStringMethod
    {
        public static void runToStringMethod()
        {

            int Number = 10;
            Number.ToString();     // called string represntations of integer

            toStringMethod2 c1 = new toStringMethod2();
            c1.firstName = "Amol";
            c1.lastName = "Rashinkar";
            Console.WriteLine(c1.ToString());  // op: Amol.toStringMethod2  -- because c1 is exist in Amol Namespace and belong to this class "toStringMethod2" 

        }
    }

    public class toStringMethod2
    {

        public string firstName { get; set; }
        public string lastName { get; set; }


        // Suppose we want here last name and first name using c1 then we will override toString method here.

        public override string ToString()   // this method output will print in above class because default toString and this override toString will be same here.
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
