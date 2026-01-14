using System;


// This is method overriding
class BaseClass {
    public virtual void print() {
        Console.WriteLine("I am a base class method");
    }
}

class ChildClass: BaseClass
{
    public override void print()
    {
        Console.WriteLine("I am a child class method");
    }
}

class MethodOverriding {

    public static void RunMethodOverriding() {

        BaseClass b = new ChildClass(); 
        //base class reference pointing to child class object
        // will invoke the overriden child class method
        b.print();
        // Output will be :  I am a child class method                  // Main difference between hiding and overriding
    }
}

// This is method hiding using virtual & new keyword in child class

class FatherClass
{
    public virtual void print()
    {
        Console.WriteLine("I am a base class method");
    }
}

class SonClass : FatherClass
{
    // Using new keyword here to hide this method.
    public new void print()
    {
        Console.WriteLine("I am a child class method");
    }
}

class MethodHiding
{

    public static void RunMethodHiding()
    {

        FatherClass b = new SonClass();
        b.print();
        // Output will be :  I am a base class method               // Main difference between hiding and overriding
        SonClass s = new SonClass();                                // To access child class method only.
        s.print();
        // Output will be :  I am a child class method            
    } 
}