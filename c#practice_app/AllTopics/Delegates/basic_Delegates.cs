using System;
// The basic syntax of delegates in C# is as follows:
// A delegates is a type safe function pointer.that holds reference to a function
// del is pointing to function params using new helloDelegate(hello); 
// return type should be match

public delegate void helloDelegate(string message); // Delegate declaration using delegate keyword.
class BasicDelegates
{

    public static void RunBasicDelegates() // public static void Main()
    {

        helloDelegate del = new helloDelegate(hello); // using delegates using constructor
        del("Hello From Delegate");                   // accessing hello function and passing message to this function
    }

    public static void hello(string message)   // If we can't make it static then this will give us compile time error
    {
        Console.WriteLine(message);
    }

}
