using System;
//  We have covered following topics

//  constructor is not a mandatory. If we do not provide then it will take automatic default parameter less consturctor as mentioned below.

//  what is class                 : class is a consist of data & behaviour. class data is represented by it's fields and behaviour is represented by it's methods.

//  purpose of class constructor  : is basically used to initialized your class fields

//  overloading class constructor : Means pass a different params to customer constructor

//  understanding this keyword    : is used to refer of an class instance OR object of that class

//  destructors                   : is used to clean of class resource thing which is holding class with it's lifetime.

class Customer
{
    string _firstName;
    string _lastName;

    public Customer() : this("No first name", "No last name") 
    {
        // for parameter less consturctor can have deafult value like this using This keyword.
    }

    // consturctor used
    public Customer(string firstName, string lastName) // it will not have return type & constructor name should be match with class name.
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    // This keyword used
    public void printFullName() {
        Console.WriteLine("FUll Name={0}", _firstName + " " + _lastName);  // OR
        Console.WriteLine("FUll Name={0}", this._firstName + " " + this._lastName);
    }

    // Here Destructor used & automatically detect by garbage collections when when class things are going to clean up
    // Should be same class names as a Destructor name but with ~ initial
    ~Customer() { 
        // clean up code();
    }
}
class ClassWithConstructor
{
    //public static void Main() -- replaced this method with below method because to run this file in another file
    public static void runClassConstructor()
    {
        // passing params to Customer class with first and last name
        Customer c1 = new Customer("Amol", "Rashinkar");
        c1.printFullName();

        // You can make parameter less consturctor using this
        Customer c2 = new Customer();
        c2.printFullName();

        // Over load customer by passing different params like below
        Customer c3 = new Customer("Xyz", "abc");
        c3.printFullName();
    }
}