using System;
// implementation of multiple inheritance using interface.
// How can we implement multiple inheritance in C#?
// In C#, multiple inheritance is not supported through classes, but it can be achieved using interfaces.
// Below is an example demonstrating multiple inheritance using interfaces.
interface IX    // base interface IX
{

    void XMethod();
}

class X : IX    // class X implementing interface IX
{
    public void XMethod()
    {
        Console.WriteLine("X Method called");
    }
}

interface IY   // base interface IY
{
    void YMethod();
}

class Y : IY    // class Y implementing interface IY
{
    public void YMethod()
    {
        Console.WriteLine("Y Method called");
    }
}


class Z : IX, IY
{
    X x = new X();      // Creating object of class X
    Y y = new Y();      // Creating object of class Y

    public void XMethod()  // Implementing XMethod of IX interface
    {
        x.XMethod(); // X interface method called

    }
    public void YMethod() // Implementing YMethod of IY interface
    {
        y.YMethod(); // Y interface method called

    }
}
class PossibleMultipleInheritance
{

    public static void RunMultipleInheritance()  // Public static void Main
    {
        Z z = new Z();  // Creating object of class Z
        z.XMethod();    // Calling XMethod of class Z
        z.YMethod();    // Calling YMethod of class Z

    }

}