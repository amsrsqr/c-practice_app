using System;
using System.IO;
using System.Runtime.Serialization;
// When to create custom exception ?
// Creating custom Exception from scratch ?
// Throwing and catching custom Exception ?
// To understand custom exception we need to understand below points
// 1) Inheritance
// 2) Exception handeling basics
// 3) Inner Exception

// We know that all the exxception inherit from System.Exception class which is "system.IO" Means "Exception" is the base class for all this.

// When you need to create custom exception?
// Ans: If there is no suitable exception available in the .net framework then we will create our own custom exception

// Example: 
/*
     1) I have a.net web application
     2) The application allows ony one logged in session per user.
     3) If the user already logged in and tried to login in another browser window and tries to login the application should throw and exception.
     4) That he is already logged in another browser.
     5) So in this case we don't have any exception suitable from .net framework to handle this scenario.
     6) So we will create our own custom exception to handle this scenario.
 */
public class customException
{
    public static void RunCustomException()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User is already logged in from another session.");
        }
        catch (UserAlreadyLoggedInException ex)  // To call the custom exception we need to catch it using catch block
        {
            Console.WriteLine($"Custom Exception Caught: {ex.Message}");
        }
    }

    [Serializable]  // If you want to use this exception across application domain then you need to mark it as serializable
    public class UserAlreadyLoggedInException : Exception
    {
        // Default constructor
        public UserAlreadyLoggedInException() : base() // This is parameter less constructor
        {
        }
        // Constructor that accepts a custom message overloaded constuctor
        public UserAlreadyLoggedInException(string message) : base(message) // This is parameterized constructor which is acception message from CustomException class
        {
        }
        // Constructor that accepts a custom message and an inner exception overloaded constuctor
        public UserAlreadyLoggedInException(string message, Exception inner) : base(message, inner)
        {
        }
        // Constructor needed for serialization

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
