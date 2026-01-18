using System;

// Just like class we can create struct in c#
// private Fields
// Public Properties
// Constructor
// Methods
public struct Customers  // Instead of "class" we add "struct" keyword here
{
    private int _id;
    private string _name;

    public int Id        // int return type get set
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name  // string return type get set
    {
        get { return _name; }
        set { this._name = value; }
    }

    public Customers(int Id, string Name)   // Constructor
    {
        this._id = Id;
        this._name = Name;
    }

    public void getDetails() { 
    Console.WriteLine("Id = {0} && Name = {1}",this._id,this._name);
    }
}
class StructsMainInfo
{
    public static void RunMainStructs()
    {
        Customers c5 = new Customers(101, "John"); // this will print 101 and John
        c5.getDetails();
        Customers c6 = new Customers();            // this will print 0 and null
        c6.Id = 102;                               // You can assign the value like this to initialize the values
        c6.Name = "Mark";
        c6.getDetails();

        // Here is new way to intialize the object of constructor

        Customers c7 = new()                       // this will print 103 and 
        {                  
            Id = 103,
            Name = "Mary" 
        }; 
        c7.getDetails();

    }
}