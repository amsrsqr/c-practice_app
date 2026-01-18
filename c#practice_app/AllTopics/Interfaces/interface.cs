using System;
// We create interface using interface keyword. just like class 
// But interface also contains properties, methods, delegated & event But only it's declaration not implementation.
// It is compile time error if we try to implement method in interface.
// Interface members are public by default.& we can't use access modifiers like public, private.
// Interface cannot contain fields.
// A class or struct can inherit from multiple interfaces. but class cannot inherit from multiple class at the same time.
// Interface can inherit from multiple interface at the same time.
// We cannot create an instance of interface in class but we can create reference of interface & assign object of class.(Last Example)
interface ICat1
{
     void Speak1(); // method declaration
}

interface ICatl2   // ICatl2 : ICat1 -- This is possible & called interface inheritance
{
     void Speak2(); // method declaration
}

public class Example : ICat1, ICatl2   // we can assign above ICatl2 only this class        // multiple interface implementation
{
    public void Speak1()  // used public access modifier because interface members are public by default
    {
        Console.WriteLine("Cat1 speaks");
    }
    public void Speak2() // used public access modifier because interface members are public by default
    {
        Console.WriteLine("Cat2 speaks again");
    }
}

public class Sample { }

// class InterfaceExample : Example, Sample -- This will give error because multiple inheritance is not supported in C#
// If we replace above comment on below class declaration then will get complie time error
class InterfaceExample
{
    public static void RunInterface()
    {
        // This could be done using interface reference
        Example example = new Example();
        example.Speak1();
        example.Speak2();

        // Output :  Cat1 speaks,  Cat2 speaks again

        //ICat1 cat1 = new ICat1();  // Cannot create instance of interface

        ICat1 cat1 = new Example();  // we can create interface reference & assign the object of class.
        cat1.Speak1();
        ICatl2 cat2 = new Example();
        cat2.Speak2();
    }

}