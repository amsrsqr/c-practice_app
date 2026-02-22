using Microsoft.VisualBasic;
using System;
using System.Threading;
using System.Threading.Tasks;

// Use ParameterizedThreadStart delegate to pass data to the thread function. Here is an example that shows the usage of ParameterizedThreadStart delegate.


namespace Amol
{
    public class parameterizedThreadStartDelegate
    {
        public static void RunParameterThreadStart() {

            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();

            // Create an instance ParameterizedThreadStart delegate
            ParameterizedThreadStart parameterizedThreadStart =new ParameterizedThreadStart(NumberStart.PrintNumbers);  // Imported by System.Threading;
            Thread T1 = new Thread(parameterizedThreadStart);

            //Thread T1= new Thread(Number.PrintNumbers)  // This line also will work here.

            // Here we are not explicitly creating an instance of ParameterizedThreadStart delegate.Then how is it working ?
            // It's working because, the compiler implicitly converts new Thread(Number.PrintNumbers)  to new Thread(new ParameterizedThreadStart(Number.PrintNumbers)).
          

            // Pass the traget number to the start function, which
            // will then be passed automatically to PrintNumbers() function
            T1.Start(target);
        }
    }

    class NumberStart
    {
        public static void PrintNumbers(object target) // ParameterizedThreadStart required pass object type target so it is object not int or string
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number)) // Conversion target object into string
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    //Q1: When to use ParameterizedThreadStart over ThreadStart delegate?
    //Ans: Use ParameterizedThreadStart delegate if you have some data to pass to the Thread function, otherwise just use ThreadStart delegate  like target passed here


    // Please note: Using ParameterizedThreadStart delegate and Thread.Start(Object) method
    // to pass data to the Thread function is not type safe as they operate on object datatype and any type of data can be passed.
    // If you try to change the data type of the target parameter of PrintNumbers() function from object to int,
    // a compiler error will be raised as the signature of PrintNumbers() function does not match with the signature of ParameterizedThreadStart delegate.



}
