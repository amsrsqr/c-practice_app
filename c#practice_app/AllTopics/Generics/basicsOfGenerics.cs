using System;
// Generics
// Learn boxing and unboxing from this topic

// Generics makes your code more independant.
// Genrics allow us to design classess and methods beyond of particular data type
// Generic classes are extensively used by collection class available in System.Collection.Generics.Namespace

public class BasicsOfGenerics
{
    public static void RunBasicOfGenerics()
    {

        bool isEqual = CalculatorOfGenerics.areEqual(1, 3);            // OP: false

        //bool isEqual = CalculatorOfGenerics.areEqual<string>("A","B"); // OP: true using <string>
        //bool isEqual = CalculatorOfGenerics.areEqual<int>(10, 10);     // OP: true using <int>


        if (isEqual)
        {

            Console.WriteLine("equal");
        }
        else
        {
            Console.WriteLine("not equal");
        }
    }
}

public class CalculatorOfGenerics   // CalculatorOfGenerics <T> --  You can make generic class like this.
{

    //There are 3 types of params


    // 1)  This is tightly coupled method at compile time for specific parameters like int.
    public static bool areEqual(int a, int b)
    {
        return a == b;
    }

    // 2)

    // Suppose we make this above sane method as obj params as below.
    // That method is not strongly coupled with params.
    // We can pass any kind of type params from above class.
    // So That' why we should have to use GENERICS.
    // This object method is not safe 
    // performance degradation will happend due to boxing and unboxing
    public static bool areEqual(object a, object b)
    {
        return a == b;
    }

    // 3)

    // Using generics here
    public static bool areEqual<T>(T a, T b)  // T is any type. As we are using in typescript.
    {
        return a.Equals(b);
    }


}

// This below makes your class generics using <int> or any other 

//   bool isEqual = CalculatorOfGenerics<int>.areEqual(10, 10); 

//    public static bool areEqual<T>(T a, T b)   instead of this you can make your class 

//  CalculatorOfGenerics<T>
