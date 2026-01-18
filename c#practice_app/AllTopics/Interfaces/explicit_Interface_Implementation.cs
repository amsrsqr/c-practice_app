using System;

// Access modifiers are not allowed for interface members
interface I1
{
    void InetrfaceMethod();  // same method signature as in I2
}
interface I2
{
    void InetrfaceMethod(); // same method signature as in I1
}
class ExplicitInterface : I1, I2  // If both interface has same method name then it will create confusion to compiler
{
    void I1.InetrfaceMethod()    // Calls I1's method explicitly
    {
        Console.WriteLine("Interface Method Implementation");
    }
    void I2.InetrfaceMethod()    // Calls I1's method explicitly
    {
        Console.WriteLine("Interface Method Implementation");
    }
    public static void RunExplicitInterface() // public static void Main()
    {
        ExplicitInterface obj = new ExplicitInterface();
        // obj.InetrfaceMethod()                                --- Compiler error
        ((I1)obj).InetrfaceMethod(); // Calls I1's method explicitly using type casting
        ((I2)obj).InetrfaceMethod(); // Calls I2's method explicitly using type casting

        // You can do it also by another way
        I1 i1 = new ExplicitInterface();
        i1.InetrfaceMethod();
        I2 i2 = new ExplicitInterface();
        i2.InetrfaceMethod();

    }
}

//Q1: A class inherit from 2 interfaces and both interfaces have same method name then how should class implement those methods?
//Ans:  We can use Explicit Interface Implementation to implement those methods. (as above example)