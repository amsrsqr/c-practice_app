using System;

// There is 4 types of parameters in c#
// 1) Pass By Value Parameteres
// 2) Pass By Reference Parameters
// 3) Output Parameteres
// 4) Parameteres Array
class methodsParametes
{

    // This is a pass by value 
    // i & j pointing to different memory location 
    // one variable will not affect the value of another variable
    public static void runPassByValue()
    {
        int i = 0;
        simpleMethods(i);
        Console.WriteLine(i); // This will print 0;
    }
    public static void simpleMethods(int j)
    {
        j = 100;
    }


    // This is a pass by reference using ref keyword
    // i & j pointing to the same memory location 
    // one variable will affect the value of another variable
    public static void runPassByReference()
    {
        int i = 0;
        simplePassMethods(ref i);
        Console.WriteLine(i); // This will print 100
    }
    public static void simplePassMethods(ref int j)
    {
        j = 100;
    }


    // This is a out parameters 
    // which can return a value in a variable using out keyword.
    // Used when you want to return more than one value
    public static void runOutParameters()
    {
        int total = 0;
        int product = 0;
        Calculate(10, 20, out total, out product);
        Console.WriteLine("total ={0} && product={1}", total, product); // output will be total = 30 && product = 200 
    }

    public static void Calculate(int i, int j, out int total, out int product)
    {

        total = i + j;
        product = i * j;
    }

    // Mostly Used Types
    // This is parameters Array
    // We used params keywords
    // This params is used to optional params to the method
    // suppose if i have not pass any params (paramsMethod(EMPTY)) then it will take default value which is [];

    public static void runParameterArray()
    {
        int[] number = new int[3];
        number[0] = 100;
        number[1] = 101;
        number[2] = 102;
        paramsMethod();              // this method format will print 0 if no params passed
        paramsMethod(number);        // this method format will print numbers if params passed
        paramsMethod(1, 2, 3, 4, 5); // You can pass number like as also & there is no limit to pass also this is called parameters arguments
    }

    public static void paramsMethod(params int[] numbers) // this is called method parameteres.
    // params int[] numbers should be last parameters in fun
    // ex. paramsMethod(int x, int y, params int[] numbers) like.
    {
        Console.WriteLine("There is total length is {0}", numbers.Length);

        foreach (int i in numbers)
            {
            Console.WriteLine(i);
        }
    }
}