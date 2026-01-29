using System;
using System.IO;

// Exception handling abuse
// How to prevent exception handling abuse.

// example:
// When an application is executing a query the database conncetion is lost. 
// Then to handle this situation generarlly used to handle these scenarios.
// Using exception handling to implement any program is bad so this is called exception handling abuse.
public class exceptionHandlingAbuse
{
    public static void RunExceptionHandlingAbuse()
    {
        try
        {
            Console.WriteLine("Please enter Numerator");
            int Numerator = Convert.ToInt32(Console.ReadLine());  // Used to convert string into int
                                                                  // When we type any String instead of number this readline will throw format exception
                                                                  // When we type any Float, Double then this will throw overflow exception
                                                                  // to handle this situation we have written like this.

            Console.WriteLine("Please enter Denominator");
            int Denominator = Convert.ToInt32(Console.ReadLine());  // Used to convert string into int

            int Result = Numerator / Denominator;

            Console.WriteLine("Result ={0}", Result);
        }

        // Here we have lot of things to handle because we don't know which exception will hit after above execution.
        // So we will solve this issue in " solvedExceptionAbuse " file
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Only number should be between in minimum and maximum value={0} && {1}", Int32.MinValue, Int32.MaxValue);
        }
        // when we divide by zero like int Result= 10/0; Then this will throw an error exception divideByZero so to handle this catch block below.
        catch (DivideByZeroException)
        {
            Console.WriteLine("The number cannot divide by zero");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }
}

