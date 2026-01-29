using System;
using System.IO;
// How to pevent exception abuse.
// We have handled if else condition instead of missuse of exception && writing too much exception. 
public class solvedExceptionAbuse
{
    public static void RunSolvedExceptionAbuse()
    {

        try
        {
            Console.WriteLine("Please enter Numerator");
            int Numerator;
            // Out is used to update the value
            bool isNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);
            // This above method will return true if the number otherwise will return false;
            // TryParse method will return booleans value always.

            if (isNumeratorConversionSuccessful)
            {
                Console.WriteLine("Please enter Denominator");
                int Denominator;
                // Out is used to update the value
                bool isDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                if (isDenominatorConversionSuccessful && Denominator != 0)
                {
                    int Result = Numerator / Denominator;

                    Console.WriteLine("Result ={0}", Result);
                }
                else
                {
                    if (Denominator == 0)
                    {
                        Console.WriteLine("The Denominator cannot be zero");
                    }
                    else
                    {
                        Console.WriteLine("Denominator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                    }

                }
            }
            else
            {
                Console.WriteLine("Numerator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

}

