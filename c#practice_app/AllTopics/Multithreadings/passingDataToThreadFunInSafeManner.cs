using System;
using System.Threading;
using System.Threading.Tasks;

// passing data to the Thread function without loosing the type safety feature 
// To pass data to the Thread function in a type safe manner,
// encapsulate the thread function and the data it needs in a helper class and use the ThreadStart delegate to execute the thread function.
// An example is shown below.

namespace Amol
{
    public class PassingDataToThreadFunInSafeManner
    {
        public static void RunPassingDataInTypeSafeManner()
        {

            /// Prompt the user for the target number
            Console.WriteLine("Please enter the target number");
            // Read from the console and store it in target variable
            int target = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the Number class, passing it
            // the target number that was read from the console
            NumberTypeSafe number = new NumberTypeSafe(target);

            // Specify the Thread function
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));

            // Alternatively we can just use Thread class constructor as shown below
            // Thread T1 = new Thread(number.PrintNumbers);                            // this is second option here to pass function
            T1.Start();
        }
    }

    // Number class also contains the data it needs to print the numbers
    class NumberTypeSafe
    {
        private int _target;
        // When an instance is created, the target number needs to be specified
        public NumberTypeSafe(int target)
        {
            // The targer number is then stored in the class private variable _target
            this._target = target;
        }

        // Function prints the numbers from 1 to the traget number that the user provided
        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
