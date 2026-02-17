using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices; // This is namespace which is for [Optional]

// making method parameters optional by using OptionalAttribute that is present in System.Runtime.InteropServices namespace
namespace Amol
{
    public class usingOptionalAttribute
    {
        public static void RunOptionalAttribute()
        {
            AddNumbers(10, 20, new int[] { 30, 40, 50 });

            // Using optional in this function
            AddDifferentNumbers(10, 20);

        }
        // If we want to add 5 integers - 10, 20, 30, 40 and 50. We call the method as shown below.
        // AddNumbers(10, 20, new int[]{30, 40, 50});
        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }

            Console.WriteLine("Total = " + result.ToString());
        }

        //We can make the 3rd parameter optional by using OptionalAttribute that is present in System.Runtime.InteropServices namespace.
        //Make sure you have "using" declaration for System.Runtime.InteropServices namespace.


        public static void AddDifferentNumbers(int firstNumber, int secondNumber,[Optional] int[] restOfTheNumbers) // you can use [OptionalAttribute]
        {
            int result = firstNumber + secondNumber;

            // loop thru restOfTheNumbers only if it is not null
            // otherwise you will get a null reference exception
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Total = " + result.ToString());
        }
    }
}
