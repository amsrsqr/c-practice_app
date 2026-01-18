using System;
//The abstract keyword is used to create abstract class
// A abstract is incomplete so it cannot instantiated. Means cannot create object of abstract class in Main method.
// Abstract class can be used as a base class for other classes.
// Abstract class cannot be sealed.
// Abstract class can have "Abstract" members , properties, events etc. but Abtract memebers are not mandatory.
// My class cannot be abstract and sealed at a same time. abstract class means use as base class and sealed means cannot inherit.

public abstract class Member1()
{   // Abstract class
    public abstract void Display(); // Abstract method does not have body. // abstract members are here

}
public class AbstractClass : Member1  // Derived class from abstract class
{
    public override void Display()  // Use override keyword to provide implementation for abstract method
    {
        Console.WriteLine("Implementation of abstract method in derived class");
    }
    public static void RunAbstractClass()  // public static void Main()
    {
        AbstractClass a =new AbstractClass(); // Create object of derived class
        a.Display(); 

        // OR

        Member1 obj = new AbstractClass(); // Create object of derived class using base class reference
        obj.Display();

    }

}

// There is two options to use abstract class

// Option 1: Provide implementation in child class for all abstract memebers which is inherited from abstract class.

// Option 1: If the class does not want to provide implemenation for all abstract members inherited from abstarct class.
// Then class has to be marked as abstract. (Ex as above).