using System;

// Method overloading 
// multiple method with the same name but different parameters/ signatures.
// combination of different params types etc.
// c# function can be overloaded using number type like int, float && Kind params like ( ref or out).
// We cannot overload method using different return type
// Means return should be same of this multiple method so that we can do it overload these methods.
// We cannot overload method using params keyword ex. as below
class MethodOverloading
{

    public static void RunMethodOverloading()
    {

        // Need to call below methods.
    }

    public static void Add(int a, int b)
    {
        Console.WriteLine("Sum {0}= ", a + b);
    }


    //Same method name but different parameters 3 params below
    public static void Add(int a, int b, int c)
    {
        Console.WriteLine("Sum {0}= ", a + b + c);
    }

    // combination of different params types  int and float below
    public static void Add(int a, float b)
    {
        Console.WriteLine("Sum {0}= ", a + b);
    }

    // OR 

    /*
     
        public static void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum {0}= ", a + b + c);
        }

        public static void Add(int a, int b, out int c)  // Using out params which will return the addition of same above func
        {
            c = a + b;
            Console.WriteLine("Sum {0}= ", c);
        }

    */

    //OR

    // Cannot overload using different return type.
    // This second method will give compile time error.

    /*
        public static void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum {0}= ", a + b + c);
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
   */

    //OR

    // Cannot overload using params keyword in params.
    // This second method will give compile time error.

    /*
        public static void Add(int a, int b, params int[] c)
        {
            Console.WriteLine("Sum {0}= ", a + b );
        }
        public static int Add(int a, int b, int[] c)
        {
            return a + b ;
        }
   */


}