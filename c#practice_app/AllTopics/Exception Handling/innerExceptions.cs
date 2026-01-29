using System;
using System.IO;
// The inner exception property return the exception instance that caused the current exception.
// To get the type of innerException use GetType() method.
// always check if inner exception is not null before using it.
public class InnerExceptions
{
    public static void RunInnerExceptions()
    {
        // This program may fail variety of reasons
        // to handle that exception we use try catch block
        try
        {
            try
            {
                Console.WriteLine("Enter first number");
                int FN = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int SN = int.Parse(Console.ReadLine());

                int Result = FN / SN;

                Console.WriteLine("The result is : " + Result);
            }
            catch (Exception ex)
            {
                string filePath = @"C:\SampleFiles\text.txt";
                // This StreamWriter used to write exception name in that of matching file path. 
                // below sw.write things will be written in that file when exceute a this program.
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType());
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("There is issue please try again");
                }
                else
                {
                    throw new FileNotFoundException(filePath + "is not present", ex); // If we not pass this ex params here then inner exception will be null
                                                                                      // Due to this we have added if condition in below exception
                }
            }
        }
        catch (Exception exception)  // Inner exception handling
        {

            Console.WriteLine("Current Exception ={0}", exception.GetType().Name);
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception ={0}", exception.InnerException.GetType().Name);
            }
        }
    }
}