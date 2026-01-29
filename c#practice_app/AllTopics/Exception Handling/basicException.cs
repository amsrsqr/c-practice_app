using System;
using System.IO; // used to read the files from system file system
// An exception is an unforeseen error that occurs during the execution of a program.
// Examples as below:
// Trying to read from a file that does not exist will throw a FileNotFoundException.
// Trying to read from a database table that does not exist will throw a SqlException.
// try: the code than can possibly cause an exception will be in the this block
// catch : to handle exception
// finally : is used to release the resources whether exception occur or not.
public class BasicException
{
    public static void RunBasicException()
    {
        StreamReader streamReader = null;
        try
        {
            //StreamReader streamReader = new StreamReader("C:\\SampleFiles\text");
            streamReader = new StreamReader(@"C:\SampleFiles\text1.txt"); // To read the file from the system file system
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();                                                      // To close the stream file reader after reading the file
        }
        catch (FileNotFoundException ex)   // This exception will only trigger when file not found if any other then this block will not execute.
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace); // this will tell you in which line exception has been ocurred.
        }
        catch (Exception ex)
        {   // This will handle all type of exception.
            // If we put this exception before above exception then above exception will throw error.
            Console.WriteLine(ex.Message);
        }
        // Even after above exception execute this block will execute compulsory.
        // Means this will execute whether exception occur or not.
        finally
        {
            if (streamReader != null) {
                streamReader.Close();

            }
            Console.WriteLine("Finally Execution completed.");
        }

        // If suppose we write this below condition instead of finally block
        // Then if FileNotFoundException exception occur this block will not execute. so we need finally block.
        /*
            if (streamReader != null)
            {
                streamReader.Close();

            }
        */

    }
}