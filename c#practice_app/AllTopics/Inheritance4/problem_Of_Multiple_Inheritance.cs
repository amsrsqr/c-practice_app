using System;
// Check part to know about inheritance, polymorphism & method overriding and method hiding
// Class B & c inherit from class A
// Class D inherit from class B & C
// if a method in D calls a method of class A using B & C  then this d will get confused to call which class method B or C ?
// So this makes ambiguity & it is called diamond problem.
// Please refer image from google for diamond problem.
class A
{

    public virtual void methodA() // Same method
    {
        Console.WriteLine("Method A implementation");
    }
}
class B : A
{

    public override void methodA() // Same method
    {
        Console.WriteLine("Method B implementation");
    }
}
class C : A
{

    public override void methodA() // Same method
    {
        Console.WriteLine("Method C implementation");
    }
}

/*
    class D : B, C  // This multiple inheritance is not possible in c#
     {
            public override void methodA() // Same method
            {
                Console.WriteLine("Method D implementation");
            }
     }
*/


class MultipleInheritanceProblems
{

    public static void RunMultipleInheritance()  // public static void Main()
    {
        // If we try to initiate object using class D then this object "d" will get confused to call which class method B or C ?
        //D d = new D(); 
        //d.methodA();
    }
}