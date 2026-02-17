using System;

// If we want to add 5 integers - 10, 20, 30, 40 and 50. We call the method as shown below.
// AddNumbers(10, 20, new int[] { 30, 40, 50 });
// At the moment all the 3 parameters are mandatory.
// If I want to add just 2 numbers, then I can invoke the method as shown below. Notice that, I am passing null as the argument for the 3rd parameter.
// AddNumbers(10, 20, null);  // This is overloading

// Now, we have 2 overloaded versions of AddNumbers() function.
// If we want to add just 2 numbers, then I can use the overloaded version of AddNumbers() function, that takes 2 parameters as shown below.
//AddNumbers(10, 20);

// If I want to add 3 or more numbers, then I can use the overloaded version of AddNumbers() function,
// that takes 3 parameters as shown below.
// AddNumbers(10, 20, new int[] { 30, 40 });

namespace Amol
{
    public class usingMethodOverloading
    {

        public static void RunOptionalMethodOverloading() {
            AddNumbers(10, 20);             // this null is not optional here
            AddNumbers(10, 20, new int[] { 30, 40 });  // this 30, 40 50 will be the part of  int[] restOfNumbers
        }


        // This is overload params using method overloading using same method name.. and calling method inside other same method.
        public static void AddNumbers(int firstNumber, int secondNumber) {

            AddNumbers(10, 20, null);
        }
        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = " + result);
        }
    }
}


// Output: 100 or 30