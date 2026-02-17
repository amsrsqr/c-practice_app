using System;
using System.Numerics;
// Optional parameters must appear after all required parameters
// You cannot do it like --    public static void AddDifferentNumbers(int firstNumber, restOfTheNumbers = null, int secondNumber, int[] )
namespace Amol
{
    public class specifyingParameterDefaults
    {

        public static void runSpecifyingParameterDefaults()
        {
            AddNumbers(10, 20, new int[] { 30, 40, 50 });

            //At the moment all the 3 parameters are mandatory. If I want to add just 2 numbers, then I can invoke the method as shown below. 
            AddNumbers(10, 20, new int[] { });

            //we have specified a default value for the 3rd parameter, it is optional. So, if we want to add just 2 numbers, we can
            AddDifferentNumbers(10, 20);
            // If  restOfTheNumbers is after that we can pass as below

            AddDifferentNumbers(10, 20, new int[] { 30, 40 });

            //IMPORTANT         
            //We  can pass specific params name arguments to function  c: 30 (This value will not be treat as b value it will be treat as c value);

            TestTwoOptional(10, c: 30);

        }

        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }

            Console.WriteLine("Total = " + result.ToString());
        }

        //We can make the 3rd parameter optional by specify a default value of null for the 3rd parameter. 

        public static void AddDifferentNumbers(int firstNumber, int secondNumber, int[] restOfTheNumbers = null)
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

        //The following method will not comiple.This is because, we are making parameter "a" optional, but it appears before the required parameters "b" and "c".

        //public static void Test(int a = 10, int b, int c) { } // Compile time error so commented-- Optional parameters must appear after all required parameters

        //The following method will compile, as optional parameter "a" is specified after all the required parameters("b" & "c").
        public static void Test(int b, int c, int a = 10)
        {
            // Do something
        }

        // Here b & C are optional
        public static void TestTwoOptional(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }

    }
}
