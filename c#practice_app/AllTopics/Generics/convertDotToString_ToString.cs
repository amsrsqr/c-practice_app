using System;
// Convert.ToString() method to ToString() method only.
// Convert.ToString() will return Empty string in str 
// Only ToString() method will return Null Pointer exception
// Depending on the type of application or architecture and what you want to achive 
// You can choose one over other.
namespace Amol
{
    public class convertDotToString_ToString
    {
        public static void RunToStringMethod()
        {
            ToCustomer c1 = new ToCustomer();
            //string str = c1.ToString();   // out: Amol.ToCustomer
            string str = Convert.ToString(c1);  // Same output
            Console.WriteLine(str);

            // if c1 is empty or null
            // example: ToCustomer c1 = null
            // Then c1.ToString() method will throw and nullpointer exception
            // Then Convert.ToString(c1); will return empty string
        }
    }

    public class ToCustomer { 
        public string Name { get; set; }
    
    }
}
