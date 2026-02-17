using System;

//There are 4 ways that can be used to make method parameters optional.
// 1. Use parameter arrays
// 2. Method overloading
// 3. Specify parameter defaults
// 4. Use OptionalAttribute that is present in " System.Runtime.InteropServices namespace "

// AddNumbers function, allows the user to add 2 or more numbers. firstNumber and secondNumber parameters are mandatory, 
// where as restOfTheNumbers parameter is optional. 

//Please note that, a parameter array ( params object[] restOfTheNumbers) must be the last parameter in a formal parameter list.
//The following function will not compile.

//If the user wants to add just 2 numbers, then he would invoke the method

//    AddNumbers(10, 20);

//    AddNumbers(10, 20, new object[] { 30, 40, 50 });    // using object params here.

namespace Amol
{
    public class useParamatersArray
    {

        public static void RunParamsArray()
        {
            AddNumbers(10, 20);                            // Third params will be optional beause params keyword.
            AddNumbers(10, 20, 30, 40, 50);                // Here 30, 40, 50 will be consider as restOfTheNumber
            AddNumbers(10, 20, new object[] { 30, 40, 50 });
        }
        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }

                Console.WriteLine("Total = " + result.ToString());
            }
        }

    }
}

