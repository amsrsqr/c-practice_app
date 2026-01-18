using System;
// Abstract classes can have implmentation for some of it's methods (see ex).
// but interface can't have implementation (see interface.cs). 
// Interfaces cannot have fields (see ex), but abstract classes can have fields (see ex).
// An interface cannot inehrit from another abstract class. it can inherit from another interface.
// An Abstract class can inherit from another abstract class or interface.
// Abstract class memebers can access modifiers but interface memebers cannot have access modifiers.


//Example of abstract class.
public abstract class Animal
{
    // can have fields
    //public int id;
    public void Display()
    {
        Console.WriteLine("I am an animal");
    }

}

//Example of interface
public interface IAnimal
{
    // Cannot have fields
    // int id;
    public void Display();

}

class AbstractClass_Vs_Interfaces
{
    public static void RunAbstarctInterface()  // public static void Main()
    {
        //
    }
}